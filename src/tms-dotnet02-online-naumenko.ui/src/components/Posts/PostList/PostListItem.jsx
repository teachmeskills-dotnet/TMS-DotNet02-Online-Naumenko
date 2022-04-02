import React from 'react';
import PostInfo from '../PostInfo';
import cl from './css/PostListItem.module.css';

const PostListItem = (props) => {
    return (
        <div className={cl.post_list__item}>
            <a href={props.link}>
                <li className={cl.post_list__item_title}>
                    {props.title}
                </li>
            </a>
            <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
        </div>
    );
};

export default PostListItem;