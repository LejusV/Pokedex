using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gabite Specie to store common natural stats of every {'abilities': ['sand-veil', 'rough-skin'], 'base_experience': 144, 'height': 14, 'id': 444, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'take-down', 'roar', 'flamethrower', 'strength', 'dragon-rage', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'secret-power', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'dragon-claw', 'natural-gift', 'dragon-pulse', 'dragon-rush', 'earth-power', 'shadow-claw', 'rock-climb', 'draco-meteor', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'incinerate', 'bulldoze', 'dual-chop', 'confide'], 'name': 'gabite', 'stats': {'hp': 68, 'attack': 90, 'defense': 65, 'special-attack': 50, 'special-defense': 55, 'speed': 82}, 'types': ['dragon', 'ground'], 'weight': 560, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ガバイト', 'roomaji': 'Gabite', 'ko': '한바이트', 'zh-Hant': '尖牙陸鯊', 'fr': 'Carmache', 'de': 'Knarksel', 'es': 'Gabite', 'it': 'Gabite', 'en': 'Gabite', 'ja': 'ガバイト', 'zh-Hans': '尖牙陆鲨'}, 'genera': {'ja-Hrkt': 'ほらあなポケモン', 'ko': '동굴포켓몬', 'zh-Hant': '洞穴寶可夢', 'fr': 'Pokémon Caverne', 'de': 'Höhle', 'es': 'Pokémon Cueva', 'it': 'Pokémon Grotta', 'en': 'Cave Pokémon', 'ja': 'ほらあなポケモン', 'zh-Hans': '洞穴宝可梦'}}
	public class SpecieGabite : PokemonSpecie
	{
#nullable enable
		private static SpecieGabite? _instance = null;
#nullable restore
        public static SpecieGabite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGabite();
                }
                return _instance;
            }
        }

		public SpecieGabite() : base(
			"Gabite",
			68, // HPs
			90, 65, // Attack & Defense
			50, 55, // Special Attack & Defense
			82			
		) {}
	}


	//Gabite Pokemon Class
	public class Gabite : Pokemon
	{

		public Gabite(string nickname, int level)
		: base(
				444,
				SpecieGabite.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gabite() : base(
			444,
			SpecieGabite.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
	}
}