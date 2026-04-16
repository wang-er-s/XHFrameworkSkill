namespace SkillEditor.Runtime
{
    public interface IAnimationComponent
    {
        public void PlayAnimation(string name, bool loop);
        public void BackIdle();
    }
}