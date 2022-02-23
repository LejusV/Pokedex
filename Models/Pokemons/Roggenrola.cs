using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Roggenrola Specie to store common natural stats of every {'abilities': ['sturdy', 'weak-armor', 'sand-force'], 'base_experience': 56, 'height': 4, 'id': 524, 'moves': ['sand-attack', 'headbutt', 'tackle', 'take-down', 'strength', 'earthquake', 'toxic', 'double-team', 'harden', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'lock-on', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'rock-smash', 'facade', 'nature-power', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'gravity', 'rock-polish', 'earth-power', 'flash-cannon', 'stone-edge', 'stealth-rock', 'wide-guard', 'autotomize', 'smack-down', 'heavy-slam', 'round', 'bulldoze', 'confide'], 'name': 'roggenrola', 'stats': {'hp': 55, 'attack': 75, 'defense': 85, 'special-attack': 25, 'special-defense': 25, 'speed': 15}, 'types': ['rock'], 'weight': 180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'legs', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ダンゴロ', 'ko': '단굴', 'zh-Hant': '石丸子', 'fr': 'Nodulithe', 'de': 'Kiesling', 'es': 'Roggenrola', 'it': 'Roggenrola', 'en': 'Roggenrola', 'ja': 'ダンゴロ', 'zh-Hans': '石丸子'}, 'genera': {'ja-Hrkt': 'マントルポケモン', 'ko': '맨틀포켓몬', 'zh-Hant': '地幔寶可夢', 'fr': 'Pokémon Manteau', 'de': 'Erdmantel', 'es': 'Pokémon Manto', 'it': 'Pokémon Placca', 'en': 'Mantle Pokémon', 'ja': 'マントルポケモン', 'zh-Hans': '地幔宝可梦'}}
	public class SpecieRoggenrola : PokemonSpecie
	{
#nullable enable
		private static SpecieRoggenrola? _instance = null;
#nullable restore
        public static SpecieRoggenrola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoggenrola();
                }
                return _instance;
            }
        }

		public SpecieRoggenrola() : base(
			"Roggenrola",
			55, // HPs
			75, 85, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
	}


	//Roggenrola Pokemon Class
	public class Roggenrola : Pokemon
	{

		public Roggenrola(string nickname, int level) : base(
			524,
			SpecieRoggenrola.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Roggenrola() : base(
			524,
			SpecieRoggenrola.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}