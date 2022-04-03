import React from 'react';
import PostInfo from '../PostInfo/PostInfo';

const PostListItem = (props) => {
    return (
        <div className='post-list__item'>
            <a href={props.link}>
                <div className='post-list__item-title'>
                    {props.title}
                </div>
            </a>
            <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
        </div>
    );
};

export default PostListItem;