using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seel Specie to store common natural stats of every {'abilities': ['thick-fat', 'hydration', 'ice-body'], 'base_experience': 65, 'height': 11, 'id': 86, 'moves': ['pay-day', 'slam', 'headbutt', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'growl', 'disable', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'peck', 'strength', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'lick', 'waterfall', 'skull-bash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'perish-song', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'whirlpool', 'fake-out', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'icicle-spear', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'fling', 'aqua-ring', 'aqua-tail', 'ice-shard', 'captivate', 'aqua-jet', 'entrainment', 'round', 'echoed-voice', 'drill-run', 'belch', 'confide', 'smart-strike'], 'name': 'seel', 'stats': {'hp': 65, 'attack': 45, 'defense': 55, 'special-attack': 45, 'special-defense': 70, 'speed': 45}, 'types': ['water'], 'weight': 900, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'パウワウ', 'roomaji': 'Pawou', 'ko': '쥬쥬', 'zh-Hant': '小海獅', 'fr': 'Otaria', 'de': 'Jurob', 'es': 'Seel', 'it': 'Seel', 'en': 'Seel', 'ja': 'パウワウ', 'zh-Hans': '小海狮'}, 'genera': {'ja-Hrkt': 'あしかポケモン', 'ko': '강치포켓몬', 'zh-Hant': '海獅寶可夢', 'fr': 'Pokémon Otarie', 'de': 'Seehund', 'es': 'Pokémon León Marino', 'it': 'Pokémon Otaria', 'en': 'Sea Lion Pokémon', 'ja': 'あしかポケモン', 'zh-Hans': '海狮宝可梦'}}
	public class SpecieSeel : PokemonSpecie
	{
#nullable enable
		private static SpecieSeel? _instance = null;
#nullable restore
        public static SpecieSeel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeel();
                }
                return _instance;
            }
        }

		public SpecieSeel() : base(
			"Seel",
			65, // HPs
			45, 55, // Attack & Defense
			45, 70, // Special Attack & Defense
			45			
		) {}
	}


	//Seel Pokemon Class
	public class Seel : Pokemon
	{

		public Seel(string nickname, int level)
		: base(
				86,
				SpecieSeel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seel(int level)
		: base(
				86,
				SpecieSeel.Instance, // Pokemon Specie
				"Seel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seel() : base(
			86,
			SpecieSeel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}