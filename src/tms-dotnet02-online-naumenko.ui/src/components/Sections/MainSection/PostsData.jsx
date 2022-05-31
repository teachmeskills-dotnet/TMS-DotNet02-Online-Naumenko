import React, { useState, useEffect } from 'react'

export default function PostsData(props) {
  const [Posts, setPosts] = useState([]);
  const [getPost,setGetPost] = useState('');
  const [updatePost,setUpdatePost] = useState('');
  const [post, setPost] = useState([]);
  const [file, setFile] = useState([]);

  if(props.removePost != '' || props.removePos != null || props.removePos != undefined){
    DeletePost(props.removePost);
  }
  if(props.addPost != null && props.addPost.postTitle != null && props.addPost.postSlug != null && props.addPost.postExcerpt != null && props.addPost.postContent != null && props.addPost.postType != null && props.addPost.postReadingTime != null && props.addPost.postFileId != null){
    console.log(props.addPost);
    AddPost(props.addPost);
  }
  if(props.updatePost != null && props.updatePost.postUpdateTitle != null && props.updatePost.postUpdateSlug != null && props.updatePost.postUpdateExcerpt != null && props.updatePost.postUpdateContent != null && props.updatePost.postUpdateType != null && props.updatePost.postUpdateReadingTime != null && props.updatePost.postUpdateFileId != null){
    UpdatePost(props.updatePost);
  }

  const getData = () => {
    fetch('https://localhost:5001/posts/')
      .then((res) => res.json())
      .then((res) => {
        setPosts(res);
        if(props.id != null){
          res.map(post => {
            if(post.id == props.id){
              setPost(post); 
              setFile(post.file);
            }
          })
        }
      })
  }

  const getPostById = (id) => {
    fetch('https://localhost:5001/posts/'+id)
  .then((res) => res.json())
  .then((res) => {
    setPost(res);
  })
  }

  async function DeletePost(id){
    if(id != undefined){
      await fetch('https://localhost:5001/posts?id=' + id,{
        method: 'DELETE',
        headers: {'Content-type': 'application/json'},
        credentials: 'include',
    });
    }
  }

  async function AddPost(post){
    await fetch('https://localhost:5001/posts',{
      method: 'Post',
      headers: {'Content-type': 'application/json'},
      credentials: 'include',
      body: JSON.stringify({
        "typeId": 1,
        "title": post.postTitle,
        "slug": post.postSlug,
        "content": post.postContent,
        "excerpt": post.postExcerpt,
        "readingTime": post.postReadingTime,
        // "date": "2022-04-19T00:00:00",
        // "modificationDate": "2022-04-19T00:00:00",
        "postStatusId": parseInt(post.postType),
        "userId": 1,
        "fileId": parseInt(post.postFileId)
      })
    });
  }

  async function UpdatePost(post){
    await fetch('https://localhost:5001/posts',{
      method: 'PUT',
      headers: {'Content-type': 'application/json'},
      credentials: 'include',
      body: JSON.stringify({
        "id": parseInt(post.postUpdateId),
        "typeId": 1,
        "title": post.postUpdateTitle,
        "slug": post.postUpdateSlug,
        "content": post.postUpdateContent,
        "excerpt": post.postUpdateExcerpt,
        "readingTime": post.postUpdateReadingTime,
        // "date": "2022-04-19T00:00:00",
        // "modificationDate": "2022-04-19T00:00:00",
        "postStatusId": parseInt(post.postUpdateType),
        "userId": 1,
        "fileId": parseInt(post.postUpdateFileId)
      })
    });
  }

  useEffect(() => {
    getData();

  }, [])

  if(props.getAll == true){
    props.posts(Posts);
  }

  if(props.getOnePost == true){
    props.getPost(post);
    props.getFile(file);
  }
  
  return (
    <>
    </>
  )
}