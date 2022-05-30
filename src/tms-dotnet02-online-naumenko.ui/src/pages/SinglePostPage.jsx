import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import PostsData from '../components/Sections/MainSection/PostsData';

const SinglePostPage = () => {
    
    const params = useParams();
    const [postTitle, setTitlePost] = useState([]);
    const [postDatePost, setDatePost] = useState([]);
    const [postImagePost, setPostImagePost] = useState([]);
    const [postContentPost, setPostContentPost] = useState([]);
    const [file, setfile] = useState('');

    const getPost = (post) => {
        setTitlePost(post.title);
        setDatePost(post.date);
        setPostImagePost(post.file);
        setPostContentPost(post.content)
    }

    const getFile = (file) => {
        setfile(file);
    }

    return (
        <main>
            <PostsData id={params.id} getPost={getPost} getFile={getFile} getOnePost={true}/>
            <div className="container">
                <div className="row">
                    <div className="col-lg-6 mx-auto">
                        <div className='post-body'>
                            <div className='text-secondary mt-2'>
                                {postDatePost}
                            </div>
                            <h1>
                                {postTitle}
                            </h1>
                            <img src={file.path} alt={postTitle} width="100%" />
                            <div className="news-body">
                                {postContentPost}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    );
};

export default SinglePostPage;