
-- Table: public.credential

-- DROP TABLE IF EXISTS public.credential;

CREATE TABLE IF NOT EXISTS public.credential
(
    userid character varying(30) COLLATE pg_catalog."default",
    username character varying(30) COLLATE pg_catalog."default",
    password character varying COLLATE pg_catalog."default"
)

TABLESPACE pg_default;

INSERT INTO credential (userid, username, password)
VALUES ('jwek4w6als4','Lily','password20')
