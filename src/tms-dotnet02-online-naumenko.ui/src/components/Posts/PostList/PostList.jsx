import React from 'react';
import PostListItem from './PostListItem';

const PostList = (props) => {

    const classes = ['post-list__title pt-3']

    if(props.sectionName === '' || props.sectionName === undefined){
        classes.push('d-none');
    }

    return (
        <div className='post-list px-4'>
            <a href=''>
                <div className={classes.join(' ')}>
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