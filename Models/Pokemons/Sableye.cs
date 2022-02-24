using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sableye Specie to store common natural stats of every {'abilities': ['keen-eye', 'stall', 'prankster'], 'base_experience': 133, 'height': 5, 'id': 302, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'low-kick', 'counter', 'seismic-toss', 'dig', 'toxic', 'psychic', 'night-shade', 'mimic', 'double-team', 'recover', 'confuse-ray', 'metronome', 'dream-eater', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'foresight', 'icy-wind', 'detect', 'endure', 'swagger', 'fury-cutter', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'torment', 'flatter', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'brick-break', 'knock-off', 'imprison', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'signal-beam', 'aerial-ace', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'natural-gift', 'feint', 'metal-burst', 'payback', 'embargo', 'fling', 'punishment', 'sucker-punch', 'poison-jab', 'dark-pulse', 'power-gem', 'nasty-plot', 'shadow-claw', 'shadow-sneak', 'zen-headbutt', 'captivate', 'ominous-wind', 'hone-claws', 'wonder-room', 'telekinesis', 'low-sweep', 'foul-play', 'round', 'incinerate', 'quash', 'retaliate', 'snarl', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'sableye', 'stats': {'hp': 50, 'attack': 75, 'defense': 75, 'special-attack': 65, 'special-defense': 65, 'speed': 50}, 'types': ['dark', 'ghost'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ヤミラミ', 'roomaji': 'Yamirami', 'ko': '깜까미', 'zh-Hant': '勾魂眼', 'fr': 'Ténéfix', 'de': 'Zobiris', 'es': 'Sableye', 'it': 'Sableye', 'en': 'Sableye', 'ja': 'ヤミラミ', 'zh-Hans': '勾魂眼'}, 'genera': {'ja-Hrkt': 'くらやみポケモン', 'ko': '어둠포켓몬', 'zh-Hant': '黑暗寶可夢', 'fr': 'Pokémon Obscurité', 'de': 'Finsternis', 'es': 'Pokémon Oscuridad', 'it': 'Pokémon Oscurità', 'en': 'Darkness Pokémon', 'ja': 'くらやみポケモン', 'zh-Hans': '黑暗宝可梦'}}
	public class SpecieSableye : PokemonSpecie
	{
#nullable enable
		private static SpecieSableye? _instance = null;
#nullable restore
        public static SpecieSableye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSableye();
                }
                return _instance;
            }
        }

		public SpecieSableye() : base(
			"Sableye",
			50, // HPs
			75, 75, // Attack & Defense
			65, 65, // Special Attack & Defense
			50			
		) {}
	}


	//Sableye Pokemon Class
	public class Sableye : Pokemon
	{

		public Sableye(string nickname, int level)
		: base(
				302,
				SpecieSableye.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sableye(int level)
		: base(
				302,
				SpecieSableye.Instance, // Pokemon Specie
				"Sableye", level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sableye() : base(
			302,
			SpecieSableye.Instance, // Pokemon Specie
			Dark.Instance, Ghost.Instance			
		) {}
	}
}