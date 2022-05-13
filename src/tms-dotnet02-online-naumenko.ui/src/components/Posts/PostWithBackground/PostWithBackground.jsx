import React from "react";
import PostInfo from '../PostInfo/PostInfo';

const PostWithBackgroud = (props) => {

    const classes = ['post-cell'];

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
            <div className='post-cell__background'>
                <picture>
                    <img src={props.background} alt={props.title} />
                </picture>
            </div>
            <a className='post-cell__link' onClick={props.link} href={props.link}>
                <div className='post-cell__title'>
                    <span>
                        {props.title}
                    </span>
                </div>
            </a>
            <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
        </div>
    );
};

export default PostWithBackgroud