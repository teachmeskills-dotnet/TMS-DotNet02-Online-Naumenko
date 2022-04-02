import React from 'react';
import cl from './PostInfo.module.css';

const PostInfo = (props) => {
    return (
        <div className={cl.post_info}>
            <ul className={cl.post_info__date}>
				<li className={cl.nav_item}>
                    {props.date}
                </li>
				<li className={cl.nav_item} title='Просмотры'>
                    <div className={cl.nav_link}>
                        <svg className={cl.svg_icon}>
                            <use href='#icon-views_small'></use>
                        </svg>
                    </div>
                    <span>{props.views}</span>
                </li>
			</ul>
			<ul className={cl.post_info__share}>
                <li className={cl.nav_item}>
					<div className={cl.nav_link}>
						<a href={'http://www.facebook.com/sharer.php?u=' + props.link} title='facebook'>
                            <svg className={cl.svg_icon}>
                                <use href='#social-facebook'></use>
                            </svg>
                        </a>
					</div>
				</li>
				<li className={cl.nav_item}>
					<div className={cl.nav_link}>
                        <a href={'http://vkontakte.ru/share.php?url=' + props.link} title='vkontakte'>
                            <svg className={cl.svg_icon}>
                                <use href='#social-vkontakte'></use>
                            </svg>
                        </a>
					</div>
				</li>
				<li className={cl.nav_item}>
					<div className={cl.nav_link}>
                        <a href={'http://connect.ok.ru/dk?st.cmd=WidgetSharePreview&st.shareUrl=' + props.link} title='odnoklassniki'>
                            <svg className={cl.svg_icon}>
                                <use href='#social-odnoklassniki'></use>
                            </svg>
                        </a>
					</div>
				</li>
                <li className={cl.nav_item}>
					<div className={cl.nav_link}>
                        <a onClick={() => props.handleToggle()}>
                            <span className={cl.post_info__share_desktop}>
                                <svg className={cl.svg_icon}>
                                    <use href='#icon-more'></use>
                                </svg>
                            </span>
                            <span className={cl.post_info__share_mobile}>
                                <svg className={cl.svg_icon}>
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