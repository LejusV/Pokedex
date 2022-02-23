using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chansey Specie to store common natural stats of every {'abilities': ['natural-cure', 'serene-grace', 'healer'], 'base_experience': 395, 'height': 11, 'id': 113, 'moves': ['pound', 'double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'growl', 'sing', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'minimize', 'defense-curl', 'light-screen', 'reflect', 'bide', 'metronome', 'egg-bomb', 'fire-blast', 'skull-bash', 'soft-boiled', 'dream-eater', 'flash', 'psywave', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'hail', 'facade', 'focus-punch', 'helping-hand', 'recycle', 'brick-break', 'endeavor', 'skill-swap', 'refresh', 'snatch', 'secret-power', 'hyper-voice', 'aromatherapy', 'rock-tomb', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'healing-wish', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'giga-impact', 'mud-bomb', 'zen-headbutt', 'rock-climb', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'heal-pulse', 'incinerate', 'retaliate', 'bestow', 'bulldoze', 'work-up', 'wild-charge', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'chansey', 'stats': {'hp': 250, 'attack': 5, 'defense': 5, 'special-attack': 35, 'special-defense': 105, 'speed': 50}, 'types': ['normal'], 'weight': 346, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 8, 'capture_rate': 30, 'color': 'pink', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ラッキー', 'roomaji': 'Lucky', 'ko': '럭키', 'zh-Hant': '吉利蛋', 'fr': 'Leveinard', 'de': 'Chaneira', 'es': 'Chansey', 'it': 'Chansey', 'en': 'Chansey', 'ja': 'ラッキー', 'zh-Hans': '吉利蛋'}, 'genera': {'ja-Hrkt': 'たまごポケモン', 'ko': '알포켓몬', 'zh-Hant': '蛋寶可夢', 'fr': 'Pokémon Œuf', 'de': 'Ei', 'es': 'Pokémon Huevo', 'it': 'Pokémon Uovo', 'en': 'Egg Pokémon', 'ja': 'たまごポケモン', 'zh-Hans': '蛋宝可梦'}}
	public class SpecieChansey : PokemonSpecie
	{
#nullable enable
		private static SpecieChansey? _instance = null;
#nullable restore
        public static SpecieChansey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChansey();
                }
                return _instance;
            }
        }

		public SpecieChansey() : base(
			"Chansey",
			250, // HPs
			5, 5, // Attack & Defense
			35, 105, // Special Attack & Defense
			50			
		) {}
	}


	//Chansey Pokemon Class
	public class Chansey : Pokemon
	{

		public Chansey(string nickname, int level) : base(
			113,
			SpecieChansey.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Chansey() : base(
			113,
			SpecieChansey.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}