``` sql
CREATE TABLE public.sys_user (
	id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
	user_name VARCHAR(100) NOT NULL UNIQUE,
    user_password VARCHAR(100) NOT NULL,
    nick_name VARCHAR(100),
    avature VARCHAR(100),
    email VARCHAR(100),
    phone VARCHAR(100),
	note varchar(500),
	is_deleted bool not null default false,
	created_time timestamptz not null default now(),
	Creator varchar(100),
	UpdatedTime TIMESTAMP,
	Updater varchar(100)
);

-- public.sys_users definition

-- Drop table

-- DROP TABLE public.sys_users;

CREATE TABLE public.sys_roles (
	id uuid NOT null PRIMARY KEY DEFAULT gen_random_uuid(),
	code varchar(100) NOT NULL,
	name varchar(100) NOT NULL,
	description varchar(100) NULL,	
	is_deleted bool NOT NULL DEFAULT false,
	created_time timestamptz NOT NULL DEFAULT now(),
	creator varchar(100) NULL,
	updated_time timestamp NULL,
	updater varchar(100) NULL	
);

CREATE TABLE public.sys_logs (
	id uuid NOT null PRIMARY KEY DEFAULT gen_random_uuid(),
	action_name varchar(100) NOT NULL,
	action_type int NOT NULL,
	actine_cost int NULL,	
	action_time timestamptz NOT NULL DEFAULT now(),
	is_deleted bool NOT NULL DEFAULT false,
	created_time timestamptz NOT NULL DEFAULT now(),
	creator varchar(100) NULL,
	updated_time timestamp NULL,
	updater varchar(100) NULL	
);

CREATE TABLE public.sys_menus (
	id uuid NOT null PRIMARY KEY DEFAULT gen_random_uuid(),
	menu_path varchar(100) NOT NULL,
	menu_name varchar(100) NOT NULL,
	menu_code varchar(100) NOT NULL,
	icon varchar(100) NULL,	
	parent_id uuid NULL,
	sort int not null default 0,
	is_visible bool NOT NULL DEFAULT false,
	is_deleted bool NOT NULL DEFAULT false,
	created_time timestamptz NOT NULL DEFAULT now(),
	creator varchar(100) NULL,
	updated_time timestamp NULL,
	updater varchar(100) NULL	
);

CREATE TABLE public.sys_role_menus (
	id uuid NOT null PRIMARY KEY DEFAULT gen_random_uuid(),	
	menu_code varchar(100) NOT NULL,
	role_code varchar(100) NULL,		
	is_deleted bool NOT NULL DEFAULT false,
	created_time timestamptz NOT NULL DEFAULT now(),
	creator varchar(100) NULL,
	updated_time timestamp NULL,
	updater varchar(100) NULL	
);

CREATE TABLE public.sys_user_roles (
	id uuid NOT null PRIMARY KEY DEFAULT gen_random_uuid(),	
	user_id uuid NOT NULL,
	role_code varchar(100) NULL,		
	is_deleted bool NOT NULL DEFAULT false,
	created_time timestamptz NOT NULL DEFAULT now(),
	creator varchar(100) NULL,
	updated_time timestamp NULL,
	updater varchar(100) NULL	
);
```


