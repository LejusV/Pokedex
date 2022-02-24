using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blissey Specie to store common natural stats of every {'abilities': ['natural-cure', 'serene-grace', 'healer'], 'base_experience': 608, 'height': 15, 'id': 242, 'moves': ['pound', 'double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'growl', 'sing', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'mimic', 'double-team', 'minimize', 'defense-curl', 'light-screen', 'metronome', 'egg-bomb', 'fire-blast', 'soft-boiled', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'hail', 'facade', 'focus-punch', 'helping-hand', 'recycle', 'brick-break', 'endeavor', 'skill-swap', 'refresh', 'snatch', 'secret-power', 'hyper-voice', 'rock-tomb', 'block', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'healing-wish', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'focus-blast', 'giga-impact', 'avalanche', 'zen-headbutt', 'rock-climb', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'heal-pulse', 'incinerate', 'retaliate', 'bestow', 'bulldoze', 'work-up', 'wild-charge', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'blissey', 'stats': {'hp': 255, 'attack': 10, 'defense': 10, 'special-attack': 75, 'special-defense': 135, 'speed': 55}, 'types': ['normal'], 'weight': 468, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 8, 'capture_rate': 30, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ハピナス', 'roomaji': 'Happinas', 'ko': '해피너스', 'zh-Hant': '幸福蛋', 'fr': 'Leuphorie', 'de': 'Heiteira', 'es': 'Blissey', 'it': 'Blissey', 'en': 'Blissey', 'ja': 'ハピナス', 'zh-Hans': '幸福蛋'}, 'genera': {'ja-Hrkt': 'しあわせポケモン', 'ko': '행복포켓몬', 'zh-Hant': '幸福寶可夢', 'fr': 'Pokémon Bonheur', 'de': 'Freude', 'es': 'Pokémon Felicidad', 'it': 'Pokémon Felicità', 'en': 'Happiness Pokémon', 'ja': 'しあわせポケモン', 'zh-Hans': '幸福宝可梦'}}
	public class SpecieBlissey : PokemonSpecie
	{
#nullable enable
		private static SpecieBlissey? _instance = null;
#nullable restore
        public static SpecieBlissey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlissey();
                }
                return _instance;
            }
        }

		public SpecieBlissey() : base(
			"Blissey",
			255, // HPs
			10, 10, // Attack & Defense
			75, 135, // Special Attack & Defense
			55			
		) {}
	}


	//Blissey Pokemon Class
	public class Blissey : Pokemon
	{

		public Blissey(string nickname, int level)
		: base(
				242,
				SpecieBlissey.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blissey(int level)
		: base(
				242,
				SpecieBlissey.Instance, // Pokemon Specie
				"Blissey", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blissey() : base(
			242,
			SpecieBlissey.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}