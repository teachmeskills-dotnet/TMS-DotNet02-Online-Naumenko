import React from 'react';
import NewsCellInfo from '../NewsCellInfo';
import SocialShareWindow from '../SocialShareWindow';

const NewsCellWithBackgroundPhoto = (props) => {
    return (
        <div className='news news__cell-shape'>
            <div className='news__cell-background'>
                <div className='news__cell-background__image position-relative' style={{backgroundImage: `url(${props.background})`}}> 
                </div>
            </div>
            <a href={props.link} className='news__cell-title text-white'>
                <span>
                    {props.title}
                </span>
            </a>
            <NewsCellInfo link={props.link} date={props.date} views={props.views}/>
            <SocialShareWindow />
        </div>
    );
};

export default NewsCellWithBackgroundPhoto;