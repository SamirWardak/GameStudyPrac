using System;
namespace fangame
{
    public interface Magic
    {
        // To perform magic
        bool performSpell(Player player = null, int strenght = 0);
    }

}
