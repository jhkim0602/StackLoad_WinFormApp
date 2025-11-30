import json
import datetime

def escape_sql(value):
    if value is None:
        return "null"
    if isinstance(value, str):
        return "'" + value.replace("'", "''") + "'"
    return str(value)

def generate_insert_sql(json_file_path, output_file_path):
    with open(json_file_path, 'r', encoding='utf-8') as f:
        data = json.load(f)

    sql_statements = []
    sql_statements.append("-- Auto-generated from stacks.json")
    sql_statements.append("DELETE FROM techs;")
    sql_statements.append("")

    # Map existing IDs if possible, or just assign sequentially
    # The user wants to "add based on this", so I'll just regenerate the whole thing to be safe and clean.
    # Current insert.sql has specific IDs, I will try to preserve them if they match name/slug, otherwise just sequence.
    # Actually, simpler to just regenerate all with sequential IDs 1..N based on json order?
    # But wait, insert.sql had specific IDs for specific items.
    # Svelte=1, Flask=2, C++=3, Express.js=4, Next.js=5, Kotlin=6, OpenAI Codex=7, Supabase=8
    
    # Let's try to keep stable IDs for existing ones if we can, but the json order is different.
    # The previous insert.sql seems to have been generated or manually created with that order.
    # To avoid confusion, I will assign IDs sequentially based on the JSON order. 
    # Since I am doing "DELETE FROM techs;", IDs will be reset (unless there are foreign keys? No, this is a simple app).
    
    # Wait, if I change IDs, it might affect other things if there were relationships. 
    # But looking at the schema, 'techs' seems to be a main table. 
    # The user said "add to this", implying appending. 
    # But "DELETE FROM techs;" is at the top of insert.sql, so it wipes anyway.
    # So regenerating all is fine.
    
    id_counter = 1
    for item in data:
        # Handle fields
        name = item.get('name')
        slug = item.get('slug')
        category = item.get('category')
        description = item.get('description')
        logo_url = item.get('logoUrl', '') # Note: json has logoUrl, db col is logo_url
        popularity = item.get('popularity', 0)
        homepage = item.get('homepage')
        repo = item.get('repo')
        
        # JSON fields need to be dumped to string
        learning_resources = json.dumps(item.get('learning_resources', []), ensure_ascii=False)
        project_suitability = json.dumps(item.get('project_suitability', []), ensure_ascii=False)
        learning_difficulty = json.dumps(item.get('learning_difficulty', {}), ensure_ascii=False)
        
        ai_explanation = item.get('ai_explanation')
        
        # created_at, updated_at -> sysdate
        
        columns = [
            "id", "name", "slug", "category", "description", "logo_url", "popularity", 
            "learning_resources", "ai_explanation", "homepage", "repo", 
            "project_suitability", "learning_difficulty", "created_at", "updated_at"
        ]
        
        values = [
            str(id_counter),
            escape_sql(name),
            escape_sql(slug),
            escape_sql(category),
            escape_sql(description),
            escape_sql(logo_url),
            str(popularity),
            escape_sql(learning_resources),
            escape_sql(ai_explanation),
            escape_sql(homepage),
            escape_sql(repo),
            escape_sql(project_suitability),
            escape_sql(learning_difficulty),
            "sysdate",
            "sysdate"
        ]
        
        sql = f"INSERT INTO techs ({', '.join(columns)}) VALUES ({', '.join(values)});"
        sql_statements.append(sql)
        sql_statements.append("")
        id_counter += 1

    sql_statements.append("COMMIT;")
    sql_statements.append("/")
    sql_statements.append("")

    with open(output_file_path, 'w', encoding='utf-8') as f:
        f.write('\n'.join(sql_statements))

    print(f"Generated {len(sql_statements)} lines to {output_file_path}")

if __name__ == "__main__":
    generate_insert_sql(
        r"c:\Users\seojh\source\repos\StackLoad_WinFormApp\stacks.json",
        r"c:\Users\seojh\source\repos\StackLoad_WinFormApp\insert.sql"
    )
