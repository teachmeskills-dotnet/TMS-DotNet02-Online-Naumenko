import React from 'react';
import PostListItem from './PostListItem';

const PostList = (props) => {
    return (
        <div className='post-list px-4 pt-3'>
            <a href=''>
                <div className='post-list__title'>
                    {props.sectionName}
                </div>
            </a>
            <ul>
                {props.posts.map( post => 
                    <PostListItem key={post.id} title={post.title} link={post.link} date={post.date} views={post.views} handleToggle={props.handleToggle}/>
                )}
           </ul>
        </div>
    );
};

export default PostList;