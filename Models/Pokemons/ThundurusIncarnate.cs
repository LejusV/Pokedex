using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Thundurus-Incarnate Specie to store common natural stats of every {'abilities': ['prankster', 'defiant'], 'base_experience': 261, 'height': 15, 'id': 642, 'moves': ['thunder-punch', 'fly', 'thrash', 'bite', 'hyper-beam', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'agility', 'double-team', 'rest', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'charge', 'taunt', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'astonish', 'bulk-up', 'shock-wave', 'hammer-arm', 'u-turn', 'payback', 'embargo', 'fling', 'heal-block', 'dark-pulse', 'focus-blast', 'giga-impact', 'nasty-plot', 'flash-cannon', 'discharge', 'grass-knot', 'charge-beam', 'smack-down', 'sludge-wave', 'foul-play', 'round', 'sky-drop', 'incinerate', 'volt-switch', 'electroweb', 'wild-charge', 'confide', 'smart-strike', 'brutal-swing'], 'name': 'thundurus-incarnate', 'stats': {'hp': 79, 'attack': 115, 'defense': 70, 'special-attack': 125, 'special-defense': 80, 'speed': 111}, 'types': ['electric', 'flying'], 'weight': 610, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 0, 'capture_rate': 3, 'color': 'blue', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ボルトロス', 'ko': '볼트로스', 'zh-Hant': '雷電雲', 'fr': 'Fulguris', 'de': 'Voltolos', 'es': 'Thundurus', 'it': 'Thundurus', 'en': 'Thundurus', 'ja': 'ボルトロス', 'zh-Hans': '雷电云'}, 'genera': {'ja-Hrkt': 'らいげきポケモン', 'ko': '뇌격포켓몬', 'zh-Hant': '雷擊寶可夢', 'fr': 'Pokémon Foudroyeur', 'de': 'Torpedo', 'es': 'Pokémon Centella', 'it': 'Pokémon Fulminante', 'en': 'Bolt Strike Pokémon', 'ja': 'らいげきポケモン', 'zh-Hans': '雷击宝可梦'}}
	public class SpecieThundurusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieThundurusIncarnate? _instance = null;
#nullable restore
        public static SpecieThundurusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThundurusIncarnate();
                }
                return _instance;
            }
        }

		public SpecieThundurusIncarnate() : base(
			"Thundurus-Incarnate",
			79, // HPs
			115, 70, // Attack & Defense
			125, 80, // Special Attack & Defense
			111			
		) {}
	}


	//Thundurus-Incarnate Pokemon Class
	public class ThundurusIncarnate : Pokemon
	{

		public ThundurusIncarnate(string nickname, int level) : base(
			642,
			SpecieThundurusIncarnate.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance, Flying.Instance			
		) {}

		public ThundurusIncarnate() : base(
			642,
			SpecieThundurusIncarnate.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
	}
}