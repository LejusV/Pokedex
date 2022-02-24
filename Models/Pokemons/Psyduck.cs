using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Psyduck Specie to store common natural stats of every {'abilities': ['damp', 'cloud-nine', 'swift-swim'], 'base_experience': 64, 'height': 8, 'id': 54, 'moves': ['mega-punch', 'pay-day', 'ice-punch', 'scratch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'disable', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'confusion', 'psychic', 'hypnosis', 'rage', 'mimic', 'screech', 'double-team', 'confuse-ray', 'light-screen', 'bide', 'waterfall', 'swift', 'skull-bash', 'amnesia', 'flash', 'fury-swipes', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'iron-tail', 'hidden-power', 'cross-chop', 'rain-dance', 'psych-up', 'future-sight', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'role-play', 'brick-break', 'yawn', 'refresh', 'secret-power', 'dive', 'signal-beam', 'aerial-ace', 'water-sport', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'fling', 'worry-seed', 'aqua-tail', 'shadow-claw', 'mud-bomb', 'zen-headbutt', 'captivate', 'hone-claws', 'wonder-room', 'psyshock', 'telekinesis', 'synchronoise', 'soak', 'simple-beam', 'round', 'clear-smog', 'scald', 'confide', 'power-up-punch'], 'name': 'psyduck', 'stats': {'hp': 50, 'attack': 52, 'defense': 48, 'special-attack': 65, 'special-defense': 50, 'speed': 55}, 'types': ['water'], 'weight': 196, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'コダック', 'roomaji': 'Koduck', 'ko': '고라파덕', 'zh-Hant': '可達鴨', 'fr': 'Psykokwak', 'de': 'Enton', 'es': 'Psyduck', 'it': 'Psyduck', 'en': 'Psyduck', 'ja': 'コダック', 'zh-Hans': '可达鸭'}, 'genera': {'ja-Hrkt': 'あひるポケモン', 'ko': '오리포켓몬', 'zh-Hant': '鴨寶可夢', 'fr': 'Pokémon Canard', 'de': 'Ente', 'es': 'Pokémon Pato', 'it': 'Pokémon Papero', 'en': 'Duck Pokémon', 'ja': 'あひるポケモン', 'zh-Hans': '鸭宝可梦'}}
	public class SpeciePsyduck : PokemonSpecie
	{
#nullable enable
		private static SpeciePsyduck? _instance = null;
#nullable restore
        public static SpeciePsyduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePsyduck();
                }
                return _instance;
            }
        }

		public SpeciePsyduck() : base(
			"Psyduck",
			50, // HPs
			52, 48, // Attack & Defense
			65, 50, // Special Attack & Defense
			55			
		) {}
	}


	//Psyduck Pokemon Class
	public class Psyduck : Pokemon
	{

		public Psyduck(string nickname, int level)
		: base(
				54,
				SpeciePsyduck.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Psyduck() : base(
			54,
			SpeciePsyduck.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}