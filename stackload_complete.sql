-- ==============================================
-- 1. 사용자 계정 생성 (필요한 경우에만 SYSTEM 계정으로 실행)
-- ==============================================
-- conn system/system
-- create user stackload identified by 1111;
-- grant connect to hong1;
--grant resource, create view, create table to stackload;

-- ==============================================
-- 2. 기존 객체 삭제 (테이블 및 시노님)
-- ==============================================
-- 시노님 삭제 (ORA-00955 에러 방지)
-- 에러가 발생해도 무시하고 진행하세요.
drop synonym tech_comment_likes;
drop synonym tech_comments;
drop synonym comment_likes;
drop synonym likes;
drop synonym comments;
drop synonym posts;
drop synonym user_techs;
drop synonym techs;
drop synonym users;

-- 테이블 삭제
drop table tech_comment_likes cascade constraints;
drop table tech_comments cascade constraints;
drop table comment_likes cascade constraints;
drop table likes cascade constraints;
drop table comments cascade constraints;
drop table posts cascade constraints;
drop table user_techs cascade constraints;
drop table techs cascade constraints;
drop table users cascade constraints;
/

-- ==============================================
-- 3. USERS TABLE
-- ==============================================
create table users (
  id varchar2(50) primary key,
  name varchar2(100),
  email varchar2(100) unique,
  email_verified date,
  image varchar2(300),
  avatar_url varchar2(300),
  location varchar2(100),
  user_level varchar2(30),
  bio varchar2(2000),
  social_links clob,
  interests clob,
  posts_count number default 0,
  likes_received_count number default 0,
  comments_count number default 0,
  created_at date default sysdate,
  updated_at date default sysdate
);
/
insert into users values('u1', 'Hong Gil Dong', 'hong@bc.ac.kr', sysdate, null, null, 'Seoul', 'Beginner', 'Backend Developer', '{}', '[]', 0, 0, 0, sysdate, sysdate);
insert into users values('u2', 'Park Gil Dong', 'park@bc.ac.kr', sysdate, null, null, 'Busan', 'Junior', 'Frontend Developer', '{}', '[]', 0, 0, 0, sysdate, sysdate);
/

-- ==============================================
-- 4. TECHS TABLE
-- ==============================================
create table techs (
  id number primary key,
  name varchar2(100) unique,
  slug varchar2(100) unique,
  category varchar2(100),
  description varchar2(2000),
  logo_url varchar2(300),
  popularity number default 0,
  learning_resources clob,
  ai_explanation varchar2(2000),
  homepage varchar2(300),
  repo varchar2(300),
  project_suitability clob,
  learning_difficulty clob,
  created_at date default sysdate,
  updated_at date default sysdate
);
/

-- ==============================================
-- 5. USER_TECHS TABLE
-- ==============================================
create table user_techs (
  id number primary key,
  user_id varchar2(50),
  tech_id number,
  proficiency_level number default 1,
  created_at date default sysdate,
  constraint fk_usertech_user foreign key(user_id) references users(id) on delete cascade,
  constraint fk_usertech_tech foreign key(tech_id) references techs(id) on delete cascade
);
/
insert into user_techs values(1, 'u1', 1, 2, sysdate);
insert into user_techs values(2, 'u2', 2, 3, sysdate);
/

-- ==============================================
-- 6. POSTS TABLE
-- ==============================================
create table posts (
  id number primary key,
  author_id varchar2(50),
  post_type varchar2(30),
  title varchar2(200),
  description varchar2(2000),
  status varchar2(30),
  likes_count number default 0,
  comments_count number default 0,
  views_count number default 0,
  created_at date default sysdate,
  updated_at date default sysdate,
  constraint fk_post_author foreign key(author_id) references users(id) on delete cascade
);
/
insert into posts values(1, 'u1', 'project', 'Recruiting React Project Team', 'Looking for team members.', 'recruiting', 0, 0, 0, sysdate, sysdate);
insert into posts values(2, 'u2', 'study', 'Node.js Study Group', 'Learning from scratch.', 'recruiting', 0, 0, 0, sysdate, sysdate);
/

-- ==============================================
-- 7. COMMENTS TABLE
-- ==============================================
create table comments (
  id number primary key,
  post_id number,
  author_id varchar2(50),
  parent_id number,
  content varchar2(2000),
  likes_count number default 0,
  replies_count number default 0,
  created_at date default sysdate,
  updated_at date default sysdate,
  constraint fk_comment_post foreign key(post_id) references posts(id) on delete cascade,
  constraint fk_comment_user foreign key(author_id) references users(id) on delete cascade,
  constraint fk_comment_parent foreign key(parent_id) references comments(id) on delete cascade
);
/
insert into comments values(1, 1, 'u2', null, 'Looks like a great project!', 0, 0, sysdate, sysdate);
insert into comments values(2, 2, 'u1', null, 'I want to join!', 0, 0, sysdate, sysdate);
/

-- ==============================================
-- 8. LIKES TABLE
-- ==============================================
create table likes (
  id number primary key,
  user_id varchar2(50),
  post_id number,
  created_at date default sysdate,
  constraint fk_like_user foreign key(user_id) references users(id) on delete cascade,
  constraint fk_like_post foreign key(post_id) references posts(id) on delete cascade
);
/
insert into likes values(1, 'u1', 2, sysdate);
insert into likes values(2, 'u2', 1, sysdate);
/

-- ==============================================
-- 9. COMMENT_LIKES TABLE
-- ==============================================
create table comment_likes (
  id number primary key,
  user_id varchar2(50),
  comment_id number,
  created_at date default sysdate,
  constraint fk_cl_user foreign key(user_id) references users(id) on delete cascade,
  constraint fk_cl_comment foreign key(comment_id) references comments(id) on delete cascade
);
/
insert into comment_likes values(1, 'u1', 1, sysdate);
insert into comment_likes values(2, 'u2', 2, sysdate);
/

-- ==============================================
-- 10. TECH_COMMENTS TABLE
-- ==============================================
create table tech_comments (
  id number primary key,
  tech_id number,
  author_id varchar2(50),
  parent_id number,
  content varchar2(2000),
  likes_count number default 0,
  replies_count number default 0,
  created_at date default sysdate,
  updated_at date default sysdate,
  constraint fk_tc_tech foreign key(tech_id) references techs(id) on delete cascade,
  constraint fk_tc_author foreign key(author_id) references users(id) on delete cascade,
  constraint fk_tc_parent foreign key(parent_id) references tech_comments(id) on delete cascade
);
/
insert into tech_comments values(1, 1, 'u1', null, 'React is very convenient!', 0, 0, sysdate, sysdate);
insert into tech_comments values(2, 2, 'u2', null, 'Node.js is great for APIs.', 0, 0, sysdate, sysdate);
/

-- ==============================================
-- 11. TECH_COMMENT_LIKES TABLE
-- ==============================================
create table tech_comment_likes (
  id number primary key,
  user_id varchar2(50),
  comment_id number,
  created_at date default sysdate,
  constraint fk_tcl_user foreign key(user_id) references users(id) on delete cascade,
  constraint fk_tcl_comment foreign key(comment_id) references tech_comments(id) on delete cascade
);
/
insert into tech_comment_likes values(1, 'u1', 2, sysdate);
insert into tech_comment_likes values(2, 'u2', 1, sysdate);
/

commit;
/
