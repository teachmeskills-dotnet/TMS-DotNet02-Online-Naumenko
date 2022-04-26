import React from 'react';
import PostInfo from '../PostInfo/PostInfo';

const PostAuthorOpinion = (props) => {

    const classes = ['post-cell opinion'];

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
            <a className='post-cell__link' href={props.link}>
                <div className="row m-0 p-0">
                    <div className="col-6 p-0">
                        <div className="post-cell__author">
                            <a className='' href={props.authorLink}>
                                <img src={props.background} className='me-2' alt={props.authorName} />
                                <span>
                                    {props.authorName}
                                </span>
                            </a>
                        </div>
                        <div className='post-cell__title'>
                            <span>
                                {props.title}
                            </span>
                        </div>
                    </div>
                    <div className="col-6 p-0">
                        <div className='post-cell__image'>
                            <picture>
                                <img src={props.background} alt={props.title} />
                            </picture>
                        </div>
                    </div>
                    <PostInfo date={props.date} link={props.link} views={props.views} handleToggle={props.handleToggle}/>
                </div>
            </a>
        </div>
    );
};

export default PostAuthorOpinion;