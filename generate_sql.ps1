$jsonContent = Get-Content -Raw -Path "stacks.json" -Encoding UTF8
$data = $jsonContent | ConvertFrom-Json

$sql = @()
$sql += "-- Auto-generated from stacks.json"
$sql += "DELETE FROM techs;"
$sql += ""

$id = 1
foreach ($item in $data) {
    $name = $item.name.Replace("'", "''")
    $slug = $item.slug.Replace("'", "''")
    $category = $item.category.Replace("'", "''")
    $description = $item.description.Replace("'", "''")
    $logoUrl = if ($item.logoUrl) { $item.logoUrl.Replace("'", "''") } else { "" }
    $popularity = if ($item.popularity) { $item.popularity } else { 0 }
    $homepage = if ($item.homepage) { $item.homepage.Replace("'", "''") } else { $null }
    $repo = if ($item.repo) { $item.repo.Replace("'", "''") } else { $null }
    $ai_explanation = if ($item.ai_explanation) { $item.ai_explanation.Replace("'", "''") } else { "" }
    
    # Handle JSON fields
    # Note: ConvertTo-Json escapes quotes with backslash, but SQL needs single quotes escaped.
    # We need to ensure the JSON string itself is valid JSON inside the SQL string.
    
    $lr_json = $item.learning_resources | ConvertTo-Json -Depth 10 -Compress
    $ps_json = $item.project_suitability | ConvertTo-Json -Depth 10 -Compress
    $ld_json = $item.learning_difficulty | ConvertTo-Json -Depth 10 -Compress
    
    # Escape single quotes in the JSON string for SQL
    $lr_escaped = $lr_json.Replace("'", "''")
    $ps_escaped = $ps_json.Replace("'", "''")
    $ld_escaped = $ld_json.Replace("'", "''")
    
    $val_lr = "'$lr_escaped'"
    $val_ps = "'$ps_escaped'"
    $val_ld = "'$ld_escaped'"

    $val_homepage = if ($homepage) { "'$homepage'" } else { "null" }
    $val_repo = if ($repo) { "'$repo'" } else { "null" }

    $line = "INSERT INTO techs (id, name, slug, category, description, logo_url, popularity, learning_resources, ai_explanation, homepage, repo, project_suitability, learning_difficulty, created_at, updated_at) VALUES ($id, '$name', '$slug', '$category', '$description', '$logoUrl', $popularity, $val_lr, '$ai_explanation', $val_homepage, $val_repo, $val_ps, $val_ld, sysdate, sysdate);"
    $sql += $line
    $sql += ""
    $id++
}

$sql += "COMMIT;"
$sql += "/"
$sql += ""

$sql | Set-Content -Path "insert.sql" -Encoding UTF8
Write-Host "Generated insert.sql with $id items."
