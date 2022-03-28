import React from 'react';

const SocialShareWindow = (props) => {
    return (
        <div className='share-full'>
            <ul>
                <li>
                    <a data-name='facebook'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-facebook'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>Facebook</span>
                    </a>
                </li>
                <li>
                    <a data-name='vkontakte'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-vkontakte'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>ВКонтакте</span>
                    </a>
                </li>
                <li>
                    <a data-name='odnoklassniki'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-odnoklassniki'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>Одноклассники</span>
                    </a>
                </li>
                <li>
                    <a data-name='twitter'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-twitter'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>Twitter</span>
                    </a>
                </li>
                <li>
                    <a data-name='telegram'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-telegram'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>Telegram</span>
                    </a>
                </li>
                <li>
                    <a data-name='viber'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-viber'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>Viber</span>
                    </a>
                </li>
                <li>
                    <a data-name='whatsapp'>
                        <span className='share-full__icon'>
                            <svg className='svg-icon'>
                                <use href='#social-whatsapp'></use>
                            </svg>
                        </span>
                        <span className='share-full__text'>WhatsApp</span>
                    </a>
                </li>
            </ul>
        </div>
    );
};

export default SocialShareWindow;