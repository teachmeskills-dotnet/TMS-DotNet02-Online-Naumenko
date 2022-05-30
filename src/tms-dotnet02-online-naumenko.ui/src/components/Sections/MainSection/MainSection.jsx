import React, { useState, useEffect } from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import { useNavigate } from "react-router-dom";
import PostsData from './PostsData'

const MainSection = (props) => {
    
    const [posts, setPosts] = useState([]);

    const getPosts = (posts) => {
        setPosts(posts);
    }

    const router = useNavigate();
        return (
            <section className="section-main pt__3">
                <PostsData posts={getPosts} getAll={true}/>
                <div className="row g__3">
                    <div className="col-md-6 col-lg-5 col-xl-5">
                        <PostWithBackgroud 
                        handleToggle={props.handleToggle} 
                        link={() => router(`/2022-04-19T00:00:00/bitcoin-slips-back-below-30000-as-european-regulators-renew-crypto-warnings-after-terra-luna-crash/2`)} 
                        title={"Bitcoin slips back below $30,000 as European regulators renew crypto warnings after Terra Luna crash"} 
                        date={"2022-04-19T00:00:00"} 
                        views={10} 
                        background={'https://static.euronews.com/articles/stories/06/70/41/64/1100x619_cmsv2_5f541c98-76be-5006-884a-6aeb44d3ea5d-6704164.jpg'}
                        height='lg'/>
                    </div>
                    <div className="col-md-6 col-lg-4 col-xl-3">
                        <PostList 
                        sectionName={props.sectionName}
                        handleToggle={props.handleToggle} 
                        posts={posts}/>
                    </div>
                    <div className="col-md-12 col-lg-3 col-xl-4">
                        <div className="row g__3">
                            <div className="col-md-6 col-lg-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={() => router(`/2022-04-19T00:00:00/russian-troops-storm-sievierodonetsk-as-donbas-suffers-heavy-bombardment%20/6`)} 
                                title={'Russian troops storm Sievierodonetsk as Donbas suffers heavy bombardment'} 
                                date={'2022-04-19T00:00:00'} 
                                views={10} 
                                background={'https://static.euronews.com/articles/stories/06/73/98/06/773x435_cmsv2_3bca83fd-4dfd-55c1-abee-d0e4a5ce92ce-6739806.jpg'}
                                height='sm'/>
                            </div>
                            <div className="col-md-6 col-lg-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={() => router(`/2022-04-19T00:00:00/liverpool-fans-pepper-sprayed-by-french-police-in-stadium-entry-chaos/10`)} 
                                title={'Liverpool fans pepper-sprayed by French police in stadium entry chaosа'} 
                                date={'2022-04-19T00:00:00'} 
                                views={10} 
                                background={'https://static.euronews.com/articles/stories/06/73/99/06/773x435_cmsv2_28e39cf9-5c2e-5180-bc01-527de916c93c-6739906.jpg'}
                                height='sm'/>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        );
    //}
};

export default MainSection;