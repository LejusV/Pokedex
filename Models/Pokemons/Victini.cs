using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Victini Specie to store common natural stats of every {'abilities': ['victory-star'], 'base_experience': 270, 'height': 4, 'id': 494, 'moves': ['fire-punch', 'thunder-punch', 'headbutt', 'double-edge', 'flamethrower', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'quick-attack', 'double-team', 'light-screen', 'focus-energy', 'fire-blast', 'flash', 'rest', 'substitute', 'snore', 'reversal', 'protect', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'brick-break', 'skill-swap', 'secret-power', 'overheat', 'signal-beam', 'bounce', 'shock-wave', 'u-turn', 'embargo', 'fling', 'last-resort', 'flare-blitz', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'flame-burst', 'flame-charge', 'round', 'stored-power', 'incinerate', 'final-gambit', 'inferno', 'work-up', 'wild-charge', 'searing-shot', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'victini', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['psychic', 'fire'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ビクティニ', 'ko': '비크티니', 'zh-Hant': '比克提尼', 'fr': 'Victini', 'de': 'Victini', 'es': 'Victini', 'it': 'Victini', 'en': 'Victini', 'ja': 'ビクティニ', 'zh-Hans': '比克提尼'}, 'genera': {'ja-Hrkt': 'しょうりポケモン', 'ko': '승리포켓몬', 'zh-Hant': '勝利寶可夢', 'fr': 'Pokémon Victoire', 'de': 'Triumph', 'es': 'Pokémon Victoria', 'it': 'Pokémon Vittoria', 'en': 'Victory Pokémon', 'ja': 'しょうりポケモン', 'zh-Hans': '胜利宝可梦'}}
	public class SpecieVictini : PokemonSpecie
	{
#nullable enable
		private static SpecieVictini? _instance = null;
#nullable restore
        public static SpecieVictini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVictini();
                }
                return _instance;
            }
        }

		public SpecieVictini() : base(
			"Victini",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Victini Pokemon Class
	public class Victini : Pokemon
	{

		public Victini(string nickname, int level)
		: base(
				494,
				SpecieVictini.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Victini(int level)
		: base(
				494,
				SpecieVictini.Instance, // Pokemon Specie
				"Victini", level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Victini() : base(
			494,
			SpecieVictini.Instance, // Pokemon Specie
			Psychic.Instance, Fire.Instance			
		) {}
	}
}