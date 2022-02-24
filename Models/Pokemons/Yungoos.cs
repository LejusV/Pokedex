using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yungoos Specie to store common natural stats of every {'abilities': ['stakeout', 'strong-jaw', 'adaptability'], 'base_experience': 51, 'height': 4, 'id': 734, 'moves': ['sand-attack', 'tackle', 'take-down', 'thrash', 'leer', 'bite', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'crunch', 'torment', 'facade', 'taunt', 'revenge', 'yawn', 'odor-sleuth', 'rock-tomb', 'u-turn', 'payback', 'last-resort', 'thunder-fang', 'ice-fang', 'fire-fang', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'yungoos', 'stats': {'hp': 48, 'attack': 70, 'defense': 30, 'special-attack': 30, 'special-defense': 30, 'speed': 45}, 'types': ['normal'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヤングース', 'ko': '영구스', 'zh-Hant': '貓鼬少', 'fr': 'Manglouton', 'de': 'Mangunior', 'es': 'Yungoos', 'it': 'Yungoos', 'en': 'Yungoos', 'ja': 'ヤングース', 'zh-Hans': '猫鼬少'}, 'genera': {'ja-Hrkt': 'うろつきポケモン', 'ko': '순회포켓몬', 'zh-Hant': '巡迴寶可夢', 'fr': 'Pokémon Patrouille', 'de': 'Patrouille', 'es': 'Pokémon Patrulla', 'it': 'Pokémon Pattuglia', 'en': 'Loitering Pokémon', 'ja': 'うろつきポケモン', 'zh-Hans': '巡回宝可梦'}}
	public class SpecieYungoos : PokemonSpecie
	{
#nullable enable
		private static SpecieYungoos? _instance = null;
#nullable restore
        public static SpecieYungoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYungoos();
                }
                return _instance;
            }
        }

		public SpecieYungoos() : base(
			"Yungoos",
			48, // HPs
			70, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			45			
		) {}
	}


	//Yungoos Pokemon Class
	public class Yungoos : Pokemon
	{

		public Yungoos(string nickname, int level)
		: base(
				734,
				SpecieYungoos.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Yungoos() : base(
			734,
			SpecieYungoos.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}