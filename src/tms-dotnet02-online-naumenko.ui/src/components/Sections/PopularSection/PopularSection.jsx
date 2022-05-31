import React, { useState } from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import PostAuthorOpinion from '../../Posts/PostAuthorOpinion/PostAuthorOpinion';
import { useNavigate } from 'react-router-dom';
import PostsData from '../MainSection/PostsData';

const PopularSection = (props) => {

    const [posts, setPosts] = useState([]);

    const getPosts = (posts) => {
        setPosts(posts);
    }

    const router = useNavigate();

    return (
        <section className="section-main pt__3">
            <PostsData posts={getPosts} getAll={true}/>
            <div className="row g__3">
                <div className="col-md-6 col-lg-4 col-xl-3">
                    <PostList
                    sectionName={props.sectionName}
                    handleToggle={props.handleToggle} 
                    posts={posts}/>
                </div>
                <div className="col-md-6 col-lg-8 col-xl-6">
                    <div className="row g__3">
                        <div className="col-md-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={() => router(`/2022-05-31T13:28:07.393319/norways-energy-sales-growth-spurs-accusations-of-profiting-from-war-demands-for-help/4`)} 
                            title={"Norway's energy sales growth spurs accusations of profiting from war, demands for help"} 
                            date={'2022-05-31T13:28:07.393319'} 
                            views={10} 
                            background={'https://static.euronews.com/articles/stories/06/73/86/18/773x435_cmsv2_21a9e255-64c6-5f6d-b2b7-6cb91ffd959c-6738618.jpg'}
                            height='sm'/>
                        </div>
                        <div className="col-md-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={() => router(`/2022-05-31T13:28:07.393319/liverpool-fans-pepper-sprayed-by-french-police-in-stadium-entry-chaos/3`)} 
                                title={'Liverpool fans pepper-sprayed by French police in stadium entry chaosа'} 
                                date={'2022-05-31T13:28:07.393319'} 
                                views={10} 
                                background={'https://static.euronews.com/articles/stories/06/73/99/06/773x435_cmsv2_28e39cf9-5c2e-5180-bc01-527de916c93c-6739906.jpg'}
                                height='sm'/>
                        </div>
                    </div>
                </div>
                <div className="col-xl-3 d-none d-xl-block">
                    <div className="col-12">
                        <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={() => router(`/2022-05-31T13:28:07.393319/bitcoin-slips-back-below-30000-as-european-regulators-renew-crypto-warnings-after-terra-luna-crash/1`)} 
                            title={"Bitcoin slips back below $30,000 as European regulators renew crypto warnings after Terra Luna crash"} 
                            date={"2022-05-31T13:28:07.393319"} 
                            views={10} 
                            background={'https://static.euronews.com/articles/stories/06/70/41/64/1100x619_cmsv2_5f541c98-76be-5006-884a-6aeb44d3ea5d-6704164.jpg'}
                            height='lg'/>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default PopularSection;