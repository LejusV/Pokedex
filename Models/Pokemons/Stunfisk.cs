using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stunfisk Specie to store common natural stats of every {'abilities': ['static', 'limber', 'sand-veil'], 'base_experience': 165, 'height': 7, 'id': 618, 'moves': ['tackle', 'water-gun', 'surf', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'double-team', 'bide', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'spite', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'uproar', 'facade', 'revenge', 'yawn', 'endeavor', 'secret-power', 'camouflage', 'mud-sport', 'astonish', 'rock-tomb', 'muddy-water', 'bounce', 'mud-shot', 'shock-wave', 'water-pulse', 'payback', 'me-first', 'magnet-rise', 'aqua-tail', 'earth-power', 'mud-bomb', 'discharge', 'stone-edge', 'stealth-rock', 'sludge-wave', 'foul-play', 'round', 'scald', 'reflect-type', 'bulldoze', 'electroweb', 'confide', 'eerie-impulse', 'infestation'], 'name': 'stunfisk', 'stats': {'hp': 109, 'attack': 66, 'defense': 84, 'special-attack': 81, 'special-defense': 99, 'speed': 32}, 'types': ['ground', 'electric'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water1', 'indeterminate'], 'names': {'ja-Hrkt': 'マッギョ', 'ko': '메더', 'zh-Hant': '泥巴魚', 'fr': 'Limonde', 'de': 'Flunschlik', 'es': 'Stunfisk', 'it': 'Stunfisk', 'en': 'Stunfisk', 'ja': 'マッギョ', 'zh-Hans': '泥巴鱼'}, 'genera': {'ja-Hrkt': 'トラップポケモン', 'ko': '트랩포켓몬', 'zh-Hant': '陷阱寶可夢', 'fr': 'Pokémon Piège', 'de': 'Falle', 'es': 'Pokémon Trampa', 'it': 'Pokémon Trappola', 'en': 'Trap Pokémon', 'ja': 'トラップポケモン', 'zh-Hans': '陷阱宝可梦'}}
	public class SpecieStunfisk : PokemonSpecie
	{
#nullable enable
		private static SpecieStunfisk? _instance = null;
#nullable restore
        public static SpecieStunfisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStunfisk();
                }
                return _instance;
            }
        }

		public SpecieStunfisk() : base(
			"Stunfisk",
			109, // HPs
			66, 84, // Attack & Defense
			81, 99, // Special Attack & Defense
			32			
		) {}
	}


	//Stunfisk Pokemon Class
	public class Stunfisk : Pokemon
	{

		public Stunfisk(string nickname, int level)
		: base(
				618,
				SpecieStunfisk.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stunfisk(int level)
		: base(
				618,
				SpecieStunfisk.Instance, // Pokemon Specie
				"Stunfisk", level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stunfisk() : base(
			618,
			SpecieStunfisk.Instance, // Pokemon Specie
			Ground.Instance, Electric.Instance			
		) {}
	}
}