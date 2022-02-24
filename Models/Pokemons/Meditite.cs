using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meditite Specie to store common natural stats of every {'abilities': ['pure-power', 'telepathy'], 'base_experience': 56, 'height': 6, 'id': 307, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'low-kick', 'counter', 'seismic-toss', 'strength', 'toxic', 'confusion', 'psychic', 'meditate', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'bide', 'metronome', 'swift', 'high-jump-kick', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'mind-reader', 'snore', 'reversal', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'baton-pass', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'facade', 'focus-punch', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'secret-power', 'rock-tomb', 'signal-beam', 'bulk-up', 'calm-mind', 'gravity', 'natural-gift', 'feint', 'acupressure', 'fling', 'power-trick', 'power-swap', 'guard-swap', 'force-palm', 'poison-jab', 'drain-punch', 'vacuum-wave', 'focus-blast', 'bullet-punch', 'psycho-cut', 'zen-headbutt', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'low-sweep', 'round', 'quick-guard', 'retaliate', 'work-up', 'confide', 'power-up-punch'], 'name': 'meditite', 'stats': {'hp': 30, 'attack': 40, 'defense': 55, 'special-attack': 40, 'special-defense': 55, 'speed': 60}, 'types': ['fighting', 'psychic'], 'weight': 112, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 180, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'アサナン', 'roomaji': 'Asanan', 'ko': '요가랑', 'zh-Hant': '瑪沙那', 'fr': 'Méditikka', 'de': 'Meditie', 'es': 'Meditite', 'it': 'Meditite', 'en': 'Meditite', 'ja': 'アサナン', 'zh-Hans': '玛沙那'}, 'genera': {'ja-Hrkt': 'めいそうポケモン', 'ko': '명상포켓몬', 'zh-Hant': '冥想寶可夢', 'fr': 'Pokémon Méditation', 'de': 'Meditation', 'es': 'Pokémon Meditador', 'it': 'Pokémon Meditazione', 'en': 'Meditate Pokémon', 'ja': 'めいそうポケモン', 'zh-Hans': '冥想宝可梦'}}
	public class SpecieMeditite : PokemonSpecie
	{
#nullable enable
		private static SpecieMeditite? _instance = null;
#nullable restore
        public static SpecieMeditite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeditite();
                }
                return _instance;
            }
        }

		public SpecieMeditite() : base(
			"Meditite",
			30, // HPs
			40, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			60			
		) {}
	}


	//Meditite Pokemon Class
	public class Meditite : Pokemon
	{

		public Meditite(string nickname, int level)
		: base(
				307,
				SpecieMeditite.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Meditite() : base(
			307,
			SpecieMeditite.Instance, // Pokemon Specie
			Fighting.Instance, Psychic.Instance			
		) {}
	}
}