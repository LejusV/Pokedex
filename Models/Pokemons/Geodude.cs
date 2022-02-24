using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Geodude Specie to store common natural stats of every {'abilities': ['rock-head', 'sturdy', 'sand-veil'], 'base_experience': 60, 'height': 4, 'id': 74, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'flamethrower', 'submission', 'counter', 'seismic-toss', 'strength', 'rock-throw', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'harden', 'defense-curl', 'bide', 'metronome', 'self-destruct', 'fire-blast', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'dynamic-punch', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'superpower', 'brick-break', 'secret-power', 'mud-sport', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'hammer-arm', 'gyro-ball', 'natural-gift', 'fling', 'sucker-punch', 'rock-polish', 'earth-power', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'wide-guard', 'autotomize', 'smack-down', 'round', 'incinerate', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'geodude', 'stats': {'hp': 40, 'attack': 80, 'defense': 100, 'special-attack': 30, 'special-defense': 30, 'speed': 20}, 'types': ['rock', 'ground'], 'weight': 200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'arms', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'イシツブテ', 'roomaji': 'Isitsubute', 'ko': '꼬마돌', 'zh-Hant': '小拳石', 'fr': 'Racaillou', 'de': 'Kleinstein', 'es': 'Geodude', 'it': 'Geodude', 'en': 'Geodude', 'ja': 'イシツブテ', 'zh-Hans': '小拳石'}, 'genera': {'ja-Hrkt': 'がんせきポケモン', 'ko': '암석포켓몬', 'zh-Hant': '岩石寶可夢', 'fr': 'Pokémon Roche', 'de': 'Gestein', 'es': 'Pokémon Roca', 'it': 'Pokémon Roccia', 'en': 'Rock Pokémon', 'ja': 'がんせきポケモン', 'zh-Hans': '岩石宝可梦'}}
	public class SpecieGeodude : PokemonSpecie
	{
#nullable enable
		private static SpecieGeodude? _instance = null;
#nullable restore
        public static SpecieGeodude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGeodude();
                }
                return _instance;
            }
        }

		public SpecieGeodude() : base(
			"Geodude",
			40, // HPs
			80, 100, // Attack & Defense
			30, 30, // Special Attack & Defense
			20			
		) {}
	}


	//Geodude Pokemon Class
	public class Geodude : Pokemon
	{

		public Geodude(string nickname, int level)
		: base(
				74,
				SpecieGeodude.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Geodude() : base(
			74,
			SpecieGeodude.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}