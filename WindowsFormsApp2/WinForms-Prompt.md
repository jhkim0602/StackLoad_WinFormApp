# C# WinForms 개발 사이트 데이터 관리 프로그램 개발 요청

## 프로젝트 개요
개발 관련 사이트의 데이터를 관리하는 Windows Forms 애플리케이션을 개발해주세요.
커뮤니티, 기술 목록, 유저를 관리하는 3개의 폼으로 구성됩니다.

## 기술 스택
- C# .NET Framework 4.8 또는 .NET 6.0+
- Windows Forms
- (선택) Entity Framework Core (데이터베이스 연동 시)

---

## 전체 레이아웃 및 디자인 가이드

### 메인 폼 (Form1)
- **FormBorderStyle**: Sizable
- **StartPosition**: CenterScreen
- **Size**: 1200 x 800
- **BackColor**: #F0F0F0
- **Font**: Segoe UI, 9pt
- **타이틀바 색상**: 기본 윈도우 스타일 (파란색 그라디언트)
- **타이틀**: "개발 사이트 관리 (Forms)"

### 메뉴바 (MenuStrip)
상단에 MenuStrip 추가:
- **BackColor**: #F0F0F0
- 메뉴 항목:
  - 유저 관리(U) - 클릭 시 UserManagementForm 표시
  - 커뮤니티(C) - 클릭 시 CommunityManagementForm 표시
  - 기술 목록(T) - 클릭 시 TechStackManagementForm 표시
  - 통계(S) → 하위메뉴: 일별 통계, 월별 통계, 연도별 통계
  - 종료(X) → 하위메뉴: 프로그램 종료

---

## 1. 유저 관리 폼 (UserManagementForm)

### 폼 설정
- **FormBorderStyle**: None (Panel로 구현하여 메인폼 내부에 표시)
- **Dock**: Fill
- **BackColor**: #F0F0F0
- **Padding**: 8px

### 레이아웃 구조
```
┌─────────────────────────────────────────────────────────────┐
│  [좌측 패널 320px]     │  [우측 패널 Fill]                 │
│  ┌──────────────┐      │  ┌───────────────────────────┐    │
│  │ 검색 GroupBox│      │  │ 유저 목록 GroupBox        │    │
│  └──────────────┘      │  │ (DataGridView)            │    │
│  ┌──────────────┐      │  │                           │    │
│  │유저 현황     │      │  └───────────────────────────┘    │
│  │ GroupBox     │      │  ┌───────────────────────────┐    │
│  │              │      │  │ 유저 상세 정보 GroupBox   │    │
│  │              │      │  │ (TextBox, ComboBox 등)    │    │
│  └──────────────┘      │  └───────────────────────────┘    │
└─────────────────────────────────────────────────────────────┘
```

### 좌측 패널 컨트롤

#### Panel (leftPanel)
- **Width**: 320
- **Dock**: Left
- **BackColor**: #F0F0F0
- **Padding**: 0, 0, 8, 0

#### GroupBox: "검색"
- **Location**: 0, 0
- **Width**: 312
- **Height**: 120
- **BackColor**: White
- **ForeColor**: #0000FF (파란색 텍스트)
- **FlatStyle**: System
- 내부 컨트롤:
  - Label: "이름/이메일" (60px 너비)
  - TextBox: searchTextBox (나머지 너비, Border: Fixed3D)
  - Button: "검색" (절반 너비, FlatStyle: System)
  - Button: "초기화" (절반 너비, FlatStyle: System)

#### GroupBox: "유저 현황"
- **Location**: 0, 128
- **Width**: 312
- **Dock**: Top (또는 계산된 위치)
- **BackColor**: White
- **ForeColor**: #0000FF
- 내부 컨트롤:
  - Label: "전체 유저 수:" + Label: (동적 숫자)
  - Label: "관리자:" + Label: (동적 숫자)
  - Label: "운영자:" + Label: (동적 숫자)
  - Label: "일반 유저:" + Label: (동적 숫자)

### 우측 패널 컨트롤

#### Panel (rightPanel)
- **Dock**: Fill
- **BackColor**: #F0F0F0

#### GroupBox: "유저 목록"
- **Dock**: Fill (SplitContainer 상단 패널에 배치)
- **BackColor**: White
- **ForeColor**: Black
- **Text**: "유저 목록          총 {count}건" (빨간색 텍스트는 별도 Label로)

#### DataGridView: userDataGridView
- **Dock**: Fill
- **BackgroundColor**: White
- **BorderStyle**: Fixed3D
- **AllowUserToAddRows**: False
- **AllowUserToDeleteRows**: False
- **ReadOnly**: True
- **SelectionMode**: FullRowSelect
- **MultiSelect**: False
- **RowHeadersVisible**: False
- **AlternatingRowsDefaultCellStyle.BackColor**: #F0F0F0
- **DefaultCellStyle.SelectionBackColor**: #3399FF
- **DefaultCellStyle.SelectionForeColor**: White
- **GridColor**: #D0D0D0
- **ColumnHeadersDefaultCellStyle.BackColor**: #E8E8E8
- **ColumnHeadersDefaultCellStyle.ForeColor**: #1E1E1E
- **Font**: Segoe UI, 9pt

컬럼 구조:
```csharp
dataGridView.Columns.Add("Id", "ID");          // Width: 60
dataGridView.Columns.Add("Name", "이름");       // Width: 120
dataGridView.Columns.Add("Email", "이메일");     // Width: 200
dataGridView.Columns.Add("Role", "역할");       // Width: 100
dataGridView.Columns.Add("JoinDate", "가입일"); // Width: 100
dataGridView.Columns.Add("Posts", "게시글");    // Width: 80
```

샘플 데이터:
```csharp
dataGridView.Rows.Add(1, "김철수", "kim@example.com", "관리자", "2024-01-15", 42);
dataGridView.Rows.Add(2, "이영희", "lee@example.com", "일반", "2024-02-20", 28);
dataGridView.Rows.Add(3, "박민수", "park@example.com", "운영자", "2024-03-10", 67);
dataGridView.Rows.Add(4, "정수진", "jung@example.com", "일반", "2024-04-05", 15);
```

#### SplitContainer
- **Orientation**: Horizontal
- **Dock**: Fill
- **SplitterDistance**: 400
- **Panel1**: 유저 목록 DataGridView
- **Panel2**: 유저 상세 정보 GroupBox (Height: 200)

#### GroupBox: "유저 상세 정보"
- **Dock**: Fill
- **BackColor**: White
- **Height**: 200

내부 컨트롤 (2열 그리드 레이아웃):
```
Row 1:
- Label "ID:" + TextBox (ReadOnly, BackColor: #EFEFEF)
- Label "이름:" + TextBox

Row 2:
- Label "이메일:" + TextBox
- Label "역할:" + ComboBox (Items: 관리자, 운영자, 일반)

Row 3:
- Button "수정" + Button "삭제" + Button "초기화" (1/3 너비씩)
```

### 이벤트 처리
```csharp
// DataGridView 행 선택 시 상세 정보 표시
private void userDataGridView_SelectionChanged(object sender, EventArgs e)
{
    if (userDataGridView.SelectedRows.Count > 0)
    {
        DataGridViewRow row = userDataGridView.SelectedRows[0];
        txtId.Text = row.Cells["Id"].Value.ToString();
        txtName.Text = row.Cells["Name"].Value.ToString();
        txtEmail.Text = row.Cells["Email"].Value.ToString();
        cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
    }
}
```

---

## 2. 커뮤니티 관리 폼 (CommunityManagementForm)

### 폼 설정
- UserManagementForm과 동일한 기본 설정

### 레이아웃 구조 (유저 관리와 동일한 좌우 분할)

### 좌측 패널

#### GroupBox: "필터"
- 내부 컨트롤:
  - Label "카테고리" + ComboBox (Items: 전체, 기술 토론, 경험 공유, 팁, 튜토리얼)
  - Label "제목" + TextBox
  - Button "검색" + Button "초기화"

#### GroupBox: "커뮤니티 현황"
- Label "전체 게시글:" + Label (동적)
- Label "총 조회수:" + Label (동적)
- Label "총 댓글:" + Label (동적)

### 우측 패널

#### DataGridView: communityDataGridView
컬럼 구조:
```csharp
dataGridView.Columns.Add("Id", "ID");             // Width: 60
dataGridView.Columns.Add("Title", "제목");         // Width: 300
dataGridView.Columns.Add("Author", "작성자");      // Width: 100
dataGridView.Columns.Add("Category", "카테고리");  // Width: 100
dataGridView.Columns.Add("Date", "날짜");          // Width: 100
dataGridView.Columns.Add("Views", "조회");         // Width: 70, Alignment: Center
dataGridView.Columns.Add("Comments", "댓글");      // Width: 70, Alignment: Center
```

샘플 데이터:
```csharp
dataGridView.Rows.Add(1, "React 18의 새로운 기능들", "김철수", "기술 토론", "2024-11-14", 234, 12);
dataGridView.Rows.Add(2, "TypeScript 마이그레이션 경험", "이영희", "경험 공유", "2024-11-13", 189, 8);
dataGridView.Rows.Add(3, "Docker 최적화 팁", "박민수", "팁", "2024-11-12", 156, 6);
dataGridView.Rows.Add(4, "Next.js 14 가이드", "최지훈", "튜토리얼", "2024-11-11", 312, 15);
```

#### GroupBox: "게시글 상세"
내부 컨트롤:
```
Row 1:
- Label "제목:" + TextBox (전체 너비)

Row 2:
- Label "작성자:" + TextBox (ReadOnly, 절반 너비)
- Label "카테고리:" + ComboBox (절반 너비)

Row 3:
- Button "수정" + Button "삭제" + Button "숨김" (1/3 너비씩)
```

---

## 3. 기술 스택 관리 폼 (TechStackManagementForm)

### 레이아웃 구조 (동일한 좌우 분할)

### 좌측 패널

#### GroupBox: "기술 추가"
- Label "기술명" + TextBox (Placeholder: "예: React")
- Label "카테고리" + ComboBox (Items: Frontend, Backend, Database, DevOps, Language, Cloud)
- Label "버전" + TextBox (Placeholder: "1.0.0")
- Button "추가" (전체 너비)

#### GroupBox: "기술 현황"
- Label "전체 기술:" + Label (동적)
- Label "Frontend:" + Label (동적)
- Label "Backend:" + Label (동적)
- Label "총 사용자:" + Label (동적)

### 우측 패널

#### DataGridView: techDataGridView
컬럼 구조:
```csharp
dataGridView.Columns.Add("Id", "ID");                  // Width: 60
dataGridView.Columns.Add("Name", "기술명");             // Width: 150
dataGridView.Columns.Add("Category", "카테고리");       // Width: 120
dataGridView.Columns.Add("Description", "설명");       // Width: 200
dataGridView.Columns.Add("UserCount", "사용자 수");     // Width: 100, Alignment: Center
dataGridView.Columns.Add("Version", "버전");           // Width: 100
```

샘플 데이터:
```csharp
dataGridView.Rows.Add(1, "React", "Frontend", "UI 라이브러리", 342, "18.2.0");
dataGridView.Rows.Add(2, "TypeScript", "Language", "타입 안전 JavaScript", 298, "5.0.0");
dataGridView.Rows.Add(3, "Node.js", "Backend", "JavaScript 런타임", 256, "20.0.0");
dataGridView.Rows.Add(4, "Python", "Language", "범용 언어", 198, "3.11");
dataGridView.Rows.Add(5, "Docker", "DevOps", "컨테이너 플랫폼", 167, "24.0");
```

#### GroupBox: "기술 상세"
내부 컨트롤:
```
Row 1:
- Label "기술명:" + TextBox (절반 너비)
- Label "버전:" + TextBox (절반 너비)

Row 2:
- Label "카테고리:" + ComboBox (전체 너비)

Row 3:
- Label "설명:" + TextBox (전체 너비)

Row 4:
- Button "수정" + Button "삭제" + Button "초기화" (1/3 너비씩)
```

---

## 공통 디자인 가이드라인

### 색상 팔레트
```csharp
// 색상 상수 정의
public static class AppColors
{
    public static readonly Color Background = ColorTranslator.FromHtml("#F0F0F0");
    public static readonly Color White = Color.White;
    public static readonly Color GridAlternate = ColorTranslator.FromHtml("#F0F0F0");
    public static readonly Color Selection = ColorTranslator.FromHtml("#3399FF");
    public static readonly Color Border = ColorTranslator.FromHtml("#D0D0D0");
    public static readonly Color HeaderBg = ColorTranslator.FromHtml("#E8E8E8");
    public static readonly Color TextPrimary = ColorTranslator.FromHtml("#1E1E1E");
    public static readonly Color GroupBoxTitle = ColorTranslator.FromHtml("#0000FF");
    public static readonly Color ReadOnlyBg = ColorTranslator.FromHtml("#EFEFEF");
    public static readonly Color CountRed = Color.Red;
}
```

### 버튼 스타일
- **FlatStyle**: System (기본 윈도우 스타일)
- **BackColor**: Gradient from #FEFEFE to #E8E8E8 (System 스타일로 자동)
- **BorderStyle**: Fixed3D
- **Font**: Segoe UI, 9pt
- **Height**: 24px

### TextBox 스타일
- **BorderStyle**: Fixed3D
- **Font**: Segoe UI, 9pt
- **Height**: 22px
- ReadOnly일 경우: BackColor #EFEFEF

### ComboBox 스타일
- **DropDownStyle**: DropDownList
- **FlatStyle**: System
- **Font**: Segoe UI, 9pt

### GroupBox 스타일
- **BackColor**: White
- **ForeColor**: #0000FF (제목 텍스트)
- **FlatStyle**: System
- **Font**: Segoe UI, 9pt
- **Padding**: 8px

### Label 스타일
- **Font**: Segoe UI, 9pt
- **ForeColor**: #1E1E1E
- **AutoSize**: False (정렬을 위해)
- **TextAlign**: MiddleLeft

---

## 구현 요구사항

### 1. 프로젝트 구조
```
DataManagementApp/
├── Forms/
│   ├── MainForm.cs
│   ├── UserManagementForm.cs
│   ├── CommunityManagementForm.cs
│   └── TechStackManagementForm.cs
├── Models/
│   ├── User.cs
│   ├── Post.cs
│   └── TechStack.cs
├── Helpers/
│   └── AppColors.cs
└── Program.cs
```

### 2. 데이터 모델

```csharp
// User.cs
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime JoinDate { get; set; }
    public int Posts { get; set; }
}

// Post.cs
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public DateTime Date { get; set; }
    public int Views { get; set; }
    public int Comments { get; set; }
}

// TechStack.cs
public class TechStack
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int UserCount { get; set; }
    public string Version { get; set; }
}
```

### 3. 메인 폼 구현

```csharp
public partial class MainForm : Form
{
    private Panel contentPanel;
    
    public MainForm()
    {
        InitializeComponent();
        InitializeMenu();
        InitializeContentPanel();
        ShowUserManagementForm(); // 기본 표시
    }
    
    private void InitializeContentPanel()
    {
        contentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppColors.Background
        };
        this.Controls.Add(contentPanel);
    }
    
    private void ShowUserManagementForm()
    {
        contentPanel.Controls.Clear();
        UserManagementForm form = new UserManagementForm { TopLevel = false, Dock = DockStyle.Fill };
        contentPanel.Controls.Add(form);
        form.Show();
    }
    
    // 커뮤니티, 기술스택 폼도 동일한 방식으로 구현
}
```

### 4. 필수 기능
- [x] 각 DataGridView에서 행 선택 시 하단 상세 정보 자동 표시
- [x] 검색/필터 기능 (기본 구현)
- [x] 데이터 통계 자동 계산 및 표시
- [x] 버튼 클릭 이벤트 (수정, 삭제, 추가 등)
- [x] 메뉴를 통한 폼 전환
- [ ] (선택) 데이터베이스 연동
- [ ] (선택) Excel 내보내기 기능

---

## 주의사항

1. **정확한 색상 사용**: 위에 명시된 HEX 색상 코드를 정확히 사용해주세요.
2. **DataGridView 스타일**: 행 선택 시 #3399FF 배경색, 흰색 텍스트 필수
3. **GroupBox**: 제목은 파란색(#0000FF), 배경은 흰색
4. **폰트**: 모든 컨트롤에 Segoe UI, 9pt 사용
5. **레이아웃**: SplitContainer를 사용하여 상하단 크기 조절 가���하게
6. **좌측 패널 너비**: 정확히 320px
7. **하단 상세 패널 높이**: 정확히 200px

---

## 예상 결과물

위 명세에 따라 작성된 C# WinForms 프로젝트를 생성해주세요.
각 폼은 독립적으로 동작하며, 메인 폼의 메뉴를 통해 전환 가능해야 합니다.
샘플 데이터가 이미 로드되어 있어야 하며, DataGridView에서 행을 클릭하면
하단 상세 정보 패널에 자동으로 값이 채워져야 합니다.

코드는 깔끔하고 주석이 포함되어 있어야 하며, 각 이벤트 핸들러는
명확하게 구분되어 있어야 합니다.
