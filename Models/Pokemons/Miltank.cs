using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Miltank Specie to store common natural stats of every {'abilities': ['thick-fat', 'scrappy', 'sap-sipper'], 'base_experience': 172, 'height': 12, 'id': 241, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'growl', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'bide', 'metronome', 'dizzy-punch', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'milk-drink', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'dynamic-punch', 'sweet-scent', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'rock-tomb', 'block', 'shock-wave', 'water-pulse', 'wake-up-slap', 'hammer-arm', 'gyro-ball', 'natural-gift', 'fling', 'punishment', 'focus-blast', 'giga-impact', 'zen-headbutt', 'iron-head', 'captivate', 'stealth-rock', 'after-you', 'round', 'echoed-voice', 'retaliate', 'bulldoze', 'work-up', 'heart-stamp', 'belch', 'confide', 'power-up-punch'], 'name': 'miltank', 'stats': {'hp': 95, 'attack': 80, 'defense': 105, 'special-attack': 40, 'special-defense': 70, 'speed': 100}, 'types': ['normal'], 'weight': 755, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'pink', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ミルタンク', 'roomaji': 'Miltank', 'ko': '밀탱크', 'zh-Hant': '大奶罐', 'fr': 'Écrémeuh', 'de': 'Miltank', 'es': 'Miltank', 'it': 'Miltank', 'en': 'Miltank', 'ja': 'ミルタンク', 'zh-Hans': '大奶罐'}, 'genera': {'ja-Hrkt': 'ちちうしポケモン', 'ko': '젖소포켓몬', 'zh-Hant': '乳牛寶可夢', 'fr': 'Pokémon Vachalait', 'de': 'Milchkuh', 'es': 'Pokémon Lechera', 'it': 'Pokémon Bovino', 'en': 'Milk Cow Pokémon', 'ja': 'ちちうしポケモン', 'zh-Hans': '奶牛宝可梦'}}
	public class SpecieMiltank : PokemonSpecie
	{
#nullable enable
		private static SpecieMiltank? _instance = null;
#nullable restore
        public static SpecieMiltank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMiltank();
                }
                return _instance;
            }
        }

		public SpecieMiltank() : base(
			"Miltank",
			95, // HPs
			80, 105, // Attack & Defense
			40, 70, // Special Attack & Defense
			100			
		) {}
	}


	//Miltank Pokemon Class
	public class Miltank : Pokemon
	{

		public Miltank(string nickname, int level)
		: base(
				241,
				SpecieMiltank.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Miltank(int level)
		: base(
				241,
				SpecieMiltank.Instance, // Pokemon Specie
				"Miltank", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Miltank() : base(
			241,
			SpecieMiltank.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}