import React from "react";
import PostInfo from '../PostInfo';
import cl from './css/PostWithBackground.module.css';

const PostWithBackgroud = (props) => {
    
    const classes = [cl.post__cell];

    switch(props.height){
        case 'xl':
            classes.push('post-height__xl');
            break;
        case 'lg':
            classes.push('post-height__lg');
            break;
        case 'md':
            classes.push('post-height__md');
            break;
        case 'sm':
            classes.push('post-height__sm');
            break;
        case 'xs':
            classes.push('post-height__xs');
            break;
    }

    return (
        <div className={classes.join(' ')}>
            <div className={cl.post__cell_background}>
                <picture>
                    <img src={props.background} alt={props.title} />
                </picture>
            </div>
            <a className={cl.post__cell_link} href={props.link}>
                <span className={cl.post__cell_title}>
                    {props.title}
                </span>
            </a>
            <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
        </div>
    );
};

export default PostWithBackgroud