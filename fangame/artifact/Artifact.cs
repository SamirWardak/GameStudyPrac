using System;
namespace fangame
{
    public interface Artifact
    {
        bool performSpellArtifact(Player player = null, Water water = Water.Zero);
    }

}
