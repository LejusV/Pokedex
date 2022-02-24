using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hydreigon Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 270, 'height': 18, 'id': 635, 'moves': ['fly', 'slam', 'headbutt', 'body-slam', 'bite', 'roar', 'flamethrower', 'surf', 'hyper-beam', 'strength', 'dragon-rage', 'thunder-wave', 'earthquake', 'toxic', 'double-team', 'reflect', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'outrage', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'superpower', 'secret-power', 'hyper-voice', 'rock-tomb', 'signal-beam', 'shock-wave', 'roost', 'tailwind', 'u-turn', 'payback', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'focus-blast', 'earth-power', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'draco-meteor', 'stone-edge', 'charge-beam', 'round', 'echoed-voice', 'incinerate', 'acrobatics', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'brutal-swing'], 'name': 'hydreigon', 'stats': {'hp': 92, 'attack': 105, 'defense': 90, 'special-attack': 125, 'special-defense': 90, 'speed': 98}, 'types': ['dark', 'dragon'], 'weight': 1600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'サザンドラ', 'ko': '삼삼드래', 'zh-Hant': '三首惡龍', 'fr': 'Trioxhydre', 'de': 'Trikephalo', 'es': 'Hydreigon', 'it': 'Hydreigon', 'en': 'Hydreigon', 'ja': 'サザンドラ', 'zh-Hans': '三首恶龙'}, 'genera': {'ja-Hrkt': 'きょうぼうポケモン', 'ko': '난폭포켓몬', 'zh-Hant': '凶暴寶可夢', 'fr': 'Pokémon Brutal', 'de': 'Brutal', 'es': 'Pokémon Voraz', 'it': 'Pokémon Brutale', 'en': 'Brutal Pokémon', 'ja': 'きょうぼうポケモン', 'zh-Hans': '凶暴宝可梦'}}
	public class SpecieHydreigon : PokemonSpecie
	{
#nullable enable
		private static SpecieHydreigon? _instance = null;
#nullable restore
        public static SpecieHydreigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHydreigon();
                }
                return _instance;
            }
        }

		public SpecieHydreigon() : base(
			"Hydreigon",
			92, // HPs
			105, 90, // Attack & Defense
			125, 90, // Special Attack & Defense
			98			
		) {}
	}


	//Hydreigon Pokemon Class
	public class Hydreigon : Pokemon
	{

		public Hydreigon(string nickname, int level)
		: base(
				635,
				SpecieHydreigon.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hydreigon(int level)
		: base(
				635,
				SpecieHydreigon.Instance, // Pokemon Specie
				"Hydreigon", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hydreigon() : base(
			635,
			SpecieHydreigon.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
	}
}