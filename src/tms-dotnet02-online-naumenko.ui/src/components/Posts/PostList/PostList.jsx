import React from 'react';
import PostListItem from './PostListItem';
import { useNavigate } from "react-router-dom";

const PostList = (props) => {
    const router = useNavigate();
    const listTitle = ['post-list__title pt-3'];

    if(props.sectionName === '' || props.sectionName === undefined){
        listTitle.push('d-none');
    }
    
    return (
        <div className='post-list px-4'>
            <a href=''>
                <div className={listTitle.join(' ')}>
                    {props.sectionName}
                </div>
            </a>
            <ul>
                {props.posts.slice(0, 4).map( post => 
                    <PostListItem key={post.id} title={post.title} link={() => router(`/${post.date}/${post.slug}`)} date={post.date} views={10} handleToggle={props.handleToggle}/>
                )}
           </ul>
        </div>
    );
};

export default PostList;