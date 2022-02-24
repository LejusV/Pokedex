using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hoopa Specie to store common natural stats of every {'abilities': ['magician'], 'base_experience': 270, 'height': 5, 'id': 720, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'psybeam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'destiny-bond', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'astonish', 'signal-beam', 'block', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'embargo', 'fling', 'last-resort', 'dark-pulse', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'gunk-shot', 'grass-knot', 'charge-beam', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'magic-room', 'foul-play', 'round', 'ally-switch', 'quash', 'dual-chop', 'phantom-force', 'confide', 'hyperspace-hole', 'power-up-punch'], 'name': 'hoopa', 'stats': {'hp': 80, 'attack': 110, 'defense': 60, 'special-attack': 150, 'special-defense': 130, 'speed': 70}, 'types': ['psychic', 'ghost'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'purple', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'フーパ', 'ko': '후파', 'zh-Hant': '胡帕', 'fr': 'Hoopa', 'de': 'Hoopa', 'es': 'Hoopa', 'it': 'Hoopa', 'en': 'Hoopa', 'ja': 'フーパ', 'zh-Hans': '胡帕'}, 'genera': {'ja-Hrkt': 'いたずらポケモン', 'ko': '장난포켓몬', 'zh-Hant': '頑童寶可夢', 'fr': 'Pokémon Chenapan', 'de': 'Schabernack', 'es': 'Pokémon Travesura', 'it': 'Pokémon Birba', 'en': 'Mischief Pokémon', 'ja': 'いたずらポケモン', 'zh-Hans': '顽童宝可梦'}}
	public class SpecieHoopa : PokemonSpecie
	{
#nullable enable
		private static SpecieHoopa? _instance = null;
#nullable restore
        public static SpecieHoopa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoopa();
                }
                return _instance;
            }
        }

		public SpecieHoopa() : base(
			"Hoopa",
			80, // HPs
			110, 60, // Attack & Defense
			150, 130, // Special Attack & Defense
			70			
		) {}
	}


	//Hoopa Pokemon Class
	public class Hoopa : Pokemon
	{

		public Hoopa(string nickname, int level)
		: base(
				720,
				SpecieHoopa.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hoopa() : base(
			720,
			SpecieHoopa.Instance, // Pokemon Specie
			Psychic.Instance, Ghost.Instance			
		) {}
	}
}