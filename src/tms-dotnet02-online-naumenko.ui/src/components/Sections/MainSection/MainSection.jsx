import React, { useState, useEffect } from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import { useNavigate } from "react-router-dom";
import PostsData from './PostsData'

const MainSection = (props) => {
    
    const [posts, setPosts] = useState([]);
    const [mainPost, setMainPost] = useState(null);

    const getPosts = (posts) => {
        setPosts(posts);
        setMainPost(posts.filter(p => p.id === 2)[0])
    }

    const router = useNavigate();
        return (
            <section className="section-main pt__3">
                <PostsData posts={getPosts} getAll={true}/>
                <div className="row g__3">
                    <div className="col-md-6 col-lg-5 col-xl-5">
                        <PostWithBackgroud 
                        handleToggle={props.handleToggle} 
                        link={() => router(`/${mainPost.date}/${mainPost.slug}/${mainPost.id}`)} 
                        title={"Bitcoin slips back below $30,000 as European regulators renew crypto warnings after Terra Luna crash"} 
                        date={"2022-04-19T00:00:00"} 
                        views={10} 
                        background={bgimage}
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
                                link={'https://items[0].items[0]'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'/>
                            </div>
                            <div className="col-md-6 col-lg-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={'https://items[0].items[0]'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
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