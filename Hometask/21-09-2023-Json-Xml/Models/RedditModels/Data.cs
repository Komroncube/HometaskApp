using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml.Models.RedditModels
{
    public class Data
    {
        public string approved_at_utc { get; set; }
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public string mod_reason_title { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public List<string> link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        public int pwls { get; set; }
        public string link_flair_css_class { get; set; }
        public int downs { get; set; }
        public string top_awarded_type { get; set; }
        public bool hide_score { get; set; }
        public string name { get; set; }
        public bool quarantine { get; set; }
        public string link_flair_text_color { get; set; }
        public float upvote_ratio { get; set; }
        public string link_flair_background_color { get; set; }
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public MediaEmbed media_embed { get; set; }
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public List<string> user_reports { get; set; }
        public string secure_media { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public string category { get; set; }
        public SecureMediaEmbed secure_media_embed { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public string approve_by { get; set; }
        public bool is_created_from_ads_ui { get; set; }
        public bool author_premium { get; set; }
        public string thumbnail { get; set; }
        public bool edited { get; set; }
        public string author_flair_css_class { get; set; }
        public List<string> author_flair_richtext { get; set; }
        public Gilding gildings { get; set; }
        public string content_categories { get; set; }
        public bool is_self { get; set; }
        public string mod_note { get; set; }
        public int created { get; set; }
        public string text { get; set; }
        public int wlx { get; set; }
        public string removed_by_category { get; set; }
        public string bannded_by { get; set; }
        public string author_flair_type { get; set; }
    }
}
