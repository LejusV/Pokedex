using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poliwrath Specie to store common natural stats of every {'abilities': ['water-absorb', 'damp', 'swift-swim'], 'base_experience': 230, 'height': 13, 'id': 62, 'moves': ['double-slap', 'mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'psychic', 'hypnosis', 'rage', 'mimic', 'double-team', 'defense-curl', 'bide', 'metronome', 'waterfall', 'skull-bash', 'psywave', 'rest', 'rock-slide', 'substitute', 'thief', 'mind-reader', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'endeavor', 'secret-power', 'dive', 'rock-tomb', 'bulk-up', 'water-pulse', 'natural-gift', 'payback', 'fling', 'poison-jab', 'vacuum-wave', 'focus-blast', 'giga-impact', 'rock-climb', 'captivate', 'low-sweep', 'round', 'scald', 'circle-throw', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'poliwrath', 'stats': {'hp': 90, 'attack': 95, 'defense': 95, 'special-attack': 70, 'special-defense': 90, 'speed': 70}, 'types': ['water', 'fighting'], 'weight': 540, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ニョロボン', 'roomaji': 'Nyorobon', 'ko': '강챙이', 'zh-Hant': '蚊香泳士', 'fr': 'Tartard', 'de': 'Quappo', 'es': 'Poliwrath', 'it': 'Poliwrath', 'en': 'Poliwrath', 'ja': 'ニョロボン', 'zh-Hans': '蚊香泳士'}, 'genera': {'ja-Hrkt': 'おたまポケモン', 'ko': '올챙이포켓몬', 'zh-Hant': '蝌蚪寶可夢', 'fr': 'Pokémon Têtard', 'de': 'Kaulquappe', 'es': 'Pokémon Renacuajo', 'it': 'Pokémon Girino', 'en': 'Tadpole Pokémon', 'ja': 'おたまポケモン', 'zh-Hans': '蝌蚪宝可梦'}}
	public class SpeciePoliwrath : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwrath? _instance = null;
#nullable restore
        public static SpeciePoliwrath Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwrath();
                }
                return _instance;
            }
        }

		public SpeciePoliwrath() : base(
			"Poliwrath",
			90, // HPs
			95, 95, // Attack & Defense
			70, 90, // Special Attack & Defense
			70			
		) {}
	}


	//Poliwrath Pokemon Class
	public class Poliwrath : Pokemon
	{

		public Poliwrath(string nickname, int level) : base(
			62,
			SpeciePoliwrath.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Fighting.Instance			
		) {}

		public Poliwrath() : base(
			62,
			SpeciePoliwrath.Instance, // Pokemon Specie
			Water.Instance, Fighting.Instance			
		) {}
	}
}