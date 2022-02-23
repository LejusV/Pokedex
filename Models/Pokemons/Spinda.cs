using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spinda Specie to store common natural stats of every {'abilities': ['own-tempo', 'tangled-feet', 'contrary'], 'base_experience': 126, 'height': 11, 'id': 327, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'thrash', 'double-edge', 'disable', 'psybeam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'psychic', 'hypnosis', 'mimic', 'double-team', 'defense-curl', 'metronome', 'swift', 'dream-eater', 'dizzy-punch', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'nightmare', 'snore', 'flail', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'baton-pass', 'encore', 'rapid-spin', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'uproar', 'facade', 'focus-punch', 'smelling-salts', 'helping-hand', 'trick', 'role-play', 'wish', 'assist', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'teeter-dance', 'hyper-voice', 'fake-tears', 'rock-tomb', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'psycho-shift', 'copycat', 'last-resort', 'sucker-punch', 'drain-punch', 'psycho-cut', 'zen-headbutt', 'trick-room', 'captivate', 'guard-split', 'round', 'retaliate', 'work-up', 'wild-charge', 'confide', 'power-up-punch', 'spotlight'], 'name': 'spinda', 'stats': {'hp': 60, 'attack': 60, 'defense': 60, 'special-attack': 60, 'special-defense': 60, 'speed': 60}, 'types': ['normal'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'パッチール', 'roomaji': 'Patcheel', 'ko': '얼루기', 'zh-Hant': '晃晃斑', 'fr': 'Spinda', 'de': 'Pandir', 'es': 'Spinda', 'it': 'Spinda', 'en': 'Spinda', 'ja': 'パッチール', 'zh-Hans': '晃晃斑'}, 'genera': {'ja-Hrkt': 'ぶちパンダポケモン', 'ko': '얼룩팬더포켓몬', 'zh-Hant': '斑點熊貓寶可夢', 'fr': 'Pokémon Panda Tache', 'de': 'Punkt-Panda', 'es': 'Pokémon Panda Topos', 'it': 'Pokémon Macchipanda', 'en': 'Spot Panda Pokémon', 'ja': 'ぶちパンダポケモン', 'zh-Hans': '斑点熊猫宝可梦'}}
	public class SpecieSpinda : PokemonSpecie
	{
#nullable enable
		private static SpecieSpinda? _instance = null;
#nullable restore
        public static SpecieSpinda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpinda();
                }
                return _instance;
            }
        }

		public SpecieSpinda() : base(
			"Spinda",
			60, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			60			
		) {}
	}


	//Spinda Pokemon Class
	public class Spinda : Pokemon
	{

		public Spinda(string nickname, int level) : base(
			327,
			SpecieSpinda.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Spinda() : base(
			327,
			SpecieSpinda.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}