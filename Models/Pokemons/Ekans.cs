using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ekans Specie to store common natural stats of every {'abilities': ['intimidate', 'shed-skin', 'unnerve'], 'base_experience': 58, 'height': 20, 'id': 23, 'moves': ['bind', 'slam', 'headbutt', 'body-slam', 'wrap', 'take-down', 'double-edge', 'poison-sting', 'leer', 'bite', 'disable', 'acid', 'strength', 'mega-drain', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'haze', 'bide', 'skull-bash', 'glare', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'beat-up', 'stockpile', 'spit-up', 'swallow', 'torment', 'facade', 'snatch', 'secret-power', 'poison-fang', 'rock-tomb', 'poison-tail', 'natural-gift', 'payback', 'gastro-acid', 'sucker-punch', 'poison-jab', 'dark-pulse', 'aqua-tail', 'seed-bomb', 'switcheroo', 'mud-bomb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'coil', 'acid-spray', 'round', 'bulldoze', 'belch', 'confide', 'infestation', 'brutal-swing'], 'name': 'ekans', 'stats': {'hp': 35, 'attack': 60, 'defense': 44, 'special-attack': 40, 'special-defense': 54, 'speed': 55}, 'types': ['poison'], 'weight': 69, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'purple', 'shape': 'squiggle', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground', 'dragon'], 'names': {'ja-Hrkt': 'アーボ', 'roomaji': 'Arbo', 'ko': '아보', 'zh-Hant': '阿柏蛇', 'fr': 'Abo', 'de': 'Rettan', 'es': 'Ekans', 'it': 'Ekans', 'en': 'Ekans', 'ja': 'アーボ', 'zh-Hans': '阿柏蛇'}, 'genera': {'ja-Hrkt': 'へびポケモン', 'ko': '뱀포켓몬', 'zh-Hant': '蛇寶可夢', 'fr': 'Pokémon Serpent', 'de': 'Schlange', 'es': 'Pokémon Serpiente', 'it': 'Pokémon Serpente', 'en': 'Snake Pokémon', 'ja': 'へびポケモン', 'zh-Hans': '蛇宝可梦'}}
	public class SpecieEkans : PokemonSpecie
	{
#nullable enable
		private static SpecieEkans? _instance = null;
#nullable restore
        public static SpecieEkans Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEkans();
                }
                return _instance;
            }
        }

		public SpecieEkans() : base(
			"Ekans",
			35, // HPs
			60, 44, // Attack & Defense
			40, 54, // Special Attack & Defense
			55			
		) {}
	}


	//Ekans Pokemon Class
	public class Ekans : Pokemon
	{

		public Ekans(string nickname, int level) : base(
			23,
			SpecieEkans.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance			
		) {}

		public Ekans() : base(
			23,
			SpecieEkans.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}