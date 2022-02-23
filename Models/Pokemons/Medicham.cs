using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Medicham Specie to store common natural stats of every {'abilities': ['pure-power', 'telepathy'], 'base_experience': 144, 'height': 13, 'id': 308, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'toxic', 'confusion', 'psychic', 'meditate', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'bide', 'metronome', 'swift', 'high-jump-kick', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'mind-reader', 'snore', 'reversal', 'protect', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'secret-power', 'rock-tomb', 'signal-beam', 'bulk-up', 'calm-mind', 'gravity', 'natural-gift', 'feint', 'acupressure', 'fling', 'power-trick', 'force-palm', 'poison-jab', 'drain-punch', 'vacuum-wave', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'low-sweep', 'round', 'retaliate', 'work-up', 'confide', 'power-up-punch'], 'name': 'medicham', 'stats': {'hp': 60, 'attack': 60, 'defense': 75, 'special-attack': 60, 'special-defense': 75, 'speed': 80}, 'types': ['fighting', 'psychic'], 'weight': 315, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'red', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'チャーレム', 'roomaji': 'Charem', 'ko': '요가램', 'zh-Hant': '恰雷姆', 'fr': 'Charmina', 'de': 'Meditalis', 'es': 'Medicham', 'it': 'Medicham', 'en': 'Medicham', 'ja': 'チャーレム', 'zh-Hans': '恰雷姆'}, 'genera': {'ja-Hrkt': 'めいそうポケモン', 'ko': '명상포켓몬', 'zh-Hant': '冥想寶可夢', 'fr': 'Pokémon Méditation', 'de': 'Meditation', 'es': 'Pokémon Meditador', 'it': 'Pokémon Meditazione', 'en': 'Meditate Pokémon', 'ja': 'めいそうポケモン', 'zh-Hans': '冥想宝可梦'}}
	public class SpecieMedicham : PokemonSpecie
	{
#nullable enable
		private static SpecieMedicham? _instance = null;
#nullable restore
        public static SpecieMedicham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMedicham();
                }
                return _instance;
            }
        }

		public SpecieMedicham() : base(
			"Medicham",
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			80			
		) {}
	}


	//Medicham Pokemon Class
	public class Medicham : Pokemon
	{

		public Medicham(string nickname, int level) : base(
			308,
			SpecieMedicham.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance, Psychic.Instance			
		) {}

		public Medicham() : base(
			308,
			SpecieMedicham.Instance, // Pokemon Specie
			Fighting.Instance, Psychic.Instance			
		) {}
	}
}