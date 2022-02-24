using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arbok Specie to store common natural stats of every {'abilities': ['intimidate', 'shed-skin', 'unnerve'], 'base_experience': 157, 'height': 35, 'id': 24, 'moves': ['bind', 'headbutt', 'body-slam', 'wrap', 'take-down', 'double-edge', 'poison-sting', 'leer', 'bite', 'acid', 'hyper-beam', 'strength', 'mega-drain', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'haze', 'bide', 'skull-bash', 'glare', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'stockpile', 'spit-up', 'swallow', 'torment', 'facade', 'snatch', 'secret-power', 'rock-tomb', 'natural-gift', 'payback', 'gastro-acid', 'poison-jab', 'dark-pulse', 'aqua-tail', 'seed-bomb', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'mud-bomb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'coil', 'acid-spray', 'round', 'bulldoze', 'dragon-tail', 'belch', 'confide', 'infestation', 'brutal-swing'], 'name': 'arbok', 'stats': {'hp': 60, 'attack': 95, 'defense': 69, 'special-attack': 65, 'special-defense': 79, 'speed': 80}, 'types': ['poison'], 'weight': 650, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'purple', 'shape': 'squiggle', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground', 'dragon'], 'names': {'ja-Hrkt': 'アーボック', 'roomaji': 'Arbok', 'ko': '아보크', 'zh-Hant': '阿柏怪', 'fr': 'Arbok', 'de': 'Arbok', 'es': 'Arbok', 'it': 'Arbok', 'en': 'Arbok', 'ja': 'アーボック', 'zh-Hans': '阿柏怪'}, 'genera': {'ja-Hrkt': 'コブラポケモン', 'ko': '코브라포켓몬', 'zh-Hant': '眼鏡蛇寶可夢', 'fr': 'Pokémon Cobra', 'de': 'Kobra', 'es': 'Pokémon Cobra', 'it': 'Pokémon Cobra', 'en': 'Cobra Pokémon', 'ja': 'コブラポケモン', 'zh-Hans': '眼镜蛇宝可梦'}}
	public class SpecieArbok : PokemonSpecie
	{
#nullable enable
		private static SpecieArbok? _instance = null;
#nullable restore
        public static SpecieArbok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArbok();
                }
                return _instance;
            }
        }

		public SpecieArbok() : base(
			"Arbok",
			60, // HPs
			95, 69, // Attack & Defense
			65, 79, // Special Attack & Defense
			80			
		) {}
	}


	//Arbok Pokemon Class
	public class Arbok : Pokemon
	{

		public Arbok(string nickname, int level)
		: base(
				24,
				SpecieArbok.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arbok() : base(
			24,
			SpecieArbok.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}