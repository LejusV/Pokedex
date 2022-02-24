using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wigglytuff Specie to store common natural stats of every {'abilities': ['cute-charm', 'competitive', 'frisk'], 'base_experience': 196, 'height': 10, 'id': 40, 'moves': ['double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'sing', 'disable', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'fire-blast', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'gravity', 'gyro-ball', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'focus-blast', 'giga-impact', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'magic-room', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'work-up', 'wild-charge', 'play-rough', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'wigglytuff', 'stats': {'hp': 140, 'attack': 70, 'defense': 45, 'special-attack': 85, 'special-defense': 50, 'speed': 45}, 'types': ['normal', 'fairy'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 50, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'プクリン', 'roomaji': 'Pukurin', 'ko': '푸크린', 'zh-Hant': '胖可丁', 'fr': 'Grodoudou', 'de': 'Knuddeluff', 'es': 'Wigglytuff', 'it': 'Wigglytuff', 'en': 'Wigglytuff', 'ja': 'プクリン', 'zh-Hans': '胖可丁'}, 'genera': {'ja-Hrkt': 'ふうせんポケモン', 'ko': '풍선포켓몬', 'zh-Hant': '氣球寶可夢', 'fr': 'Pokémon Bouboule', 'de': 'Ballon', 'es': 'Pokémon Globo', 'it': 'Pokémon Pallone', 'en': 'Balloon Pokémon', 'ja': 'ふうせんポケモン', 'zh-Hans': '气球宝可梦'}}
	public class SpecieWigglytuff : PokemonSpecie
	{
#nullable enable
		private static SpecieWigglytuff? _instance = null;
#nullable restore
        public static SpecieWigglytuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWigglytuff();
                }
                return _instance;
            }
        }

		public SpecieWigglytuff() : base(
			"Wigglytuff",
			140, // HPs
			70, 45, // Attack & Defense
			85, 50, // Special Attack & Defense
			45			
		) {}
	}


	//Wigglytuff Pokemon Class
	public class Wigglytuff : Pokemon
	{

		public Wigglytuff(string nickname, int level)
		: base(
				40,
				SpecieWigglytuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wigglytuff(int level)
		: base(
				40,
				SpecieWigglytuff.Instance, // Pokemon Specie
				"Wigglytuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wigglytuff() : base(
			40,
			SpecieWigglytuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
	}
}