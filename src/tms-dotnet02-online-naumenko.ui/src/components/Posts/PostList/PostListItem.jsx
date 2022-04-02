import React from 'react';
import PostInfo from '../PostInfo';
import cl from './css/PostListItem.module.css';

const PostListItem = (props) => {
    return (
        <div className="list__item pt-3">
            <a href={props.link}>
                <div className="item__title">
                    {props.title}
                </div>
            </a>
            <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
        </div>
    );
};

export default PostListItem;