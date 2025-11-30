# API 백엔드 생성 요청

**목표**: 기술 스택(Tech Stacks), 사용자(Users), 커뮤니티 게시글(Posts) 데이터를 위한 완전한 CRUD 기능을 갖춘 REST API 서버를 생성합니다.

**배경**:
이 API의 클라이언트 역할을 하는 Windows Forms 애플리케이션이 있습니다. 이 애플리케이션은 기술 스택, 사용자, 게시글이라는 세 가지 주요 리소스를 관리합니다. 이 리소스들을 위한 엔드포인트를 제공하는 백엔드 서버(Node.js/Express 또는 Python/Flask)가 필요합니다.

**요구사항**:

1.  **기술 스택**: Node.js와 Express(선호) 또는 Python Flask를 사용하세요.
2.  **데이터 지속성**: 간단한 JSON 파일 기반 데이터베이스(`lowdb` 또는 단순 `.json` 파일 읽기/쓰기)나 인메모리 데이터베이스를 사용할 수 있지만, 가능하면 재시작 후에도 데이터가 유지되도록 해주세요(JSON 파일 선호).
3.  **CORS**: WinForms 앱이 접속할 수 있도록 모든 출처(origin)에 대해 CORS를 활성화하세요.
4.  **리소스 및 엔드포인트**:

    ### 1. 기술 스택 (Tech Stacks)
    - `GET /api/techstacks` - 전체 조회
    - `GET /api/techstacks/:id` - 단일 조회
    - `POST /api/techstacks` - 신규 생성
    - `PUT /api/techstacks/:id` - 기존 항목 수정
    - `DELETE /api/techstacks/:id` - 삭제
    - **모델**:
      ```json
      {
        "id": 1,
        "name": "React",
        "category": "Frontend",
        "description": "...",
        "popularity": 100,
        "createdAt": "2023-01-01T00:00:00",
        "updatedAt": "2023-01-01T00:00:00"
      }
      ```

    ### 2. 사용자 (Users)
    - `GET /api/users` - 전체 조회
    - `GET /api/users/:id` - 단일 조회
    - `POST /api/users` - 신규 생성
    - `PUT /api/users/:id` - 기존 항목 수정
    - `DELETE /api/users/:id` - 삭제
    - **모델**:
      ```json
      {
        "id": "u1", // 레거시 시스템과 일치시키기 위한 문자열 ID
        "name": "홍길동",
        "email": "hong@example.com",
        "role": "Admin",
        "postsCount": 10,
        "createdAt": "2023-01-01T00:00:00"
      }
      ```

    ### 3. 게시글 (Posts)
    - `GET /api/posts` - 전체 조회
    - `GET /api/posts/:id` - 단일 조회
    - `POST /api/posts` - 신규 생성
    - `PUT /api/posts/:id` - 기존 항목 수정
    - `DELETE /api/posts/:id` - 삭제
    - **모델**:
      ```json
      {
        "id": 1,
        "title": "안녕하세요",
        "authorId": "u1",
        "postType": "General",
        "viewsCount": 100,
        "commentsCount": 5,
        "createdAt": "2023-01-01T00:00:00"
      }
      ```

**AI 지시사항**:
"Node.js Express 서버를 완성해 주세요. `/api/techstacks`, `/api/users`, `/api/posts`에 대한 라우트를 가지고 있어야 하며, 각각 GET, POST, PUT, DELETE를 지원해야 합니다. JSON 요청 처리를 위해 `body-parser`를 사용하고, 교차 출처 리소스 공유를 위해 `cors`를 사용하세요. 저장소로는 데이터가 디스크에 저장되도록 간단한 JSON 파일(`data/techstacks.json`, `data/users.json`, `data/posts.json`)을 사용하세요."
