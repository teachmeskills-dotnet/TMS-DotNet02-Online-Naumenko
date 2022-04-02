import React from 'react';
import PostListItem from './PostListItem';
import cl from './css/PostList.module.css';

const PostList = (props) => {

    const classes = [cl.post_list];
    classes.push('px-4 pt-3');

    return (
        <div className={classes.join(' ')}>
            <a href=''>
                <div className={cl.post_list__title}>
                    Главное
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