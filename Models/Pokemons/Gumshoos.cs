using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gumshoos Specie to store common natural stats of every {'abilities': ['stakeout', 'strong-jaw', 'adaptability'], 'base_experience': 146, 'height': 7, 'id': 735, 'moves': ['sand-attack', 'tackle', 'take-down', 'thrash', 'leer', 'bite', 'roar', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'crunch', 'torment', 'facade', 'taunt', 'yawn', 'odor-sleuth', 'rock-tomb', 'u-turn', 'payback', 'fling', 'round', 'echoed-voice', 'bulldoze', 'work-up', 'confide'], 'name': 'gumshoos', 'stats': {'hp': 88, 'attack': 110, 'defense': 60, 'special-attack': 55, 'special-defense': 60, 'speed': 45}, 'types': ['normal'], 'weight': 142, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'デカグース', 'ko': '형사구스', 'zh-Hant': '貓鼬探長', 'fr': 'Argouste', 'de': 'Manguspektor', 'es': 'Gumshoos', 'it': 'Gumshoos', 'en': 'Gumshoos', 'ja': 'デカグース', 'zh-Hans': '猫鼬探长'}, 'genera': {'ja-Hrkt': 'はりこみポケモン', 'ko': '잠복포켓몬', 'zh-Hant': '監視寶可夢', 'fr': 'Pokémon Filature', 'de': 'Beschattung', 'es': 'Pokémon Vigilante', 'it': 'Pokémon Sorveglianza', 'en': 'Stakeout Pokémon', 'ja': 'はりこみポケモン', 'zh-Hans': '蹲守宝可梦'}}
	public class SpecieGumshoos : PokemonSpecie
	{
#nullable enable
		private static SpecieGumshoos? _instance = null;
#nullable restore
        public static SpecieGumshoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGumshoos();
                }
                return _instance;
            }
        }

		public SpecieGumshoos() : base(
			"Gumshoos",
			88, // HPs
			110, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			45			
		) {}
	}


	//Gumshoos Pokemon Class
	public class Gumshoos : Pokemon
	{

		public Gumshoos(string nickname, int level)
		: base(
				735,
				SpecieGumshoos.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gumshoos() : base(
			735,
			SpecieGumshoos.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}