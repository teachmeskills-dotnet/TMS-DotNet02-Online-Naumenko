import React from 'react';

const PostInfo = (props) => {
    return (
        <div className='post-info'>
            <ul className='post-info__date col-8'>
				<li className='nav-item'>
                    {props.date}
                </li>
				<li className='nav-item' title='Просмотры'>
                    <div className='nav-link'>
                        <svg className='svg-icon'>
                            <use href='#icon-views_small'></use>
                        </svg>
                    </div>
                    <span>{props.views}</span>
                </li>
			</ul>
			<ul className='post-info__share col-4'>
                <li className='nav-item d-none d-lg-block'>
					<div className='nav-link'>
						<a href={'http://www.facebook.com/sharer.php?u=' + props.link} title='facebook'>
                            <svg className='svg-icon'>
                                <use href='#social-facebook'></use>
                            </svg>
                        </a>
					</div>
				</li>
				<li className='nav-item d-none d-lg-block'>
					<div className='nav-link'>
                        <a href={'http://vkontakte.ru/share.php?url=' + props.link} title='vkontakte'>
                            <svg className='svg-icon'>
                                <use href='#social-vkontakte'></use>
                            </svg>
                        </a>
					</div>
				</li>
				<li className='nav-item d-none d-lg-block'>
					<div className='nav-link'>
                        <a href={'http://connect.ok.ru/dk?st.cmd=WidgetSharePreview&st.shareUrl=' + props.link} title='odnoklassniki'>
                            <svg className='svg-icon'>
                                <use href='#social-odnoklassniki'></use>
                            </svg>
                        </a>
					</div>
				</li>
                <li className='nav-item'>
					<div className='nav-link'>
                        <a onClick={() => props.handleToggle()}>
                            <span className='post-info__share-desktop d-none d-lg-block'>
                                <svg className='svg-icon'>
                                    <use href='#icon-more'></use>
                                </svg>
                            </span>
                            <span className='post-info__share-mobile d-block d-lg-none'>
                                <svg className='svg-icon'>
                                    <use href='#icon-share'></use>
                                </svg>
                            </span>
                        </a>
					</div>
				</li>
			</ul>
        </div>
    );
};

export default PostInfo;