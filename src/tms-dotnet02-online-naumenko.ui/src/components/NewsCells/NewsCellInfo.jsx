import React from 'react';

const NewsCellInfo = (props) => {
    return (
        <div className='cell-info'>
            <ul className='col-8 cell-info__date'>
				<li className='nav-item'>
                    {props.date}
                </li>
				<li className='nav-item d-flex ps-2' title='Просмотры'>
                    <div className='nav-link'>
                        <svg className='svg-icon'>
                            <use href='#icon-views_small'></use>
                        </svg>
                    </div>
                    <span>{props.views}</span>
                </li>
			</ul>
			<ul className='col-4 cell-info__share'>
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
                        <a className='share-more'>
                            <span className='share-more__desktop d-none d-lg-block'>
                                <svg className='svg-icon'>
                                    <use href='#icon-more'></use>
                                </svg>
                            </span>
                            <span className='share-more__mobile d-block d-lg-none'>
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

export default NewsCellInfo;