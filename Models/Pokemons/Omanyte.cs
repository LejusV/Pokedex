using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Omanyte Specie to store common natural stats of every {'abilities': ['swift-swim', 'shell-armor', 'weak-armor'], 'base_experience': 71, 'height': 4, 'id': 138, 'moves': ['bind', 'slam', 'headbutt', 'horn-attack', 'body-slam', 'take-down', 'double-edge', 'leer', 'bite', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'toxic', 'rage', 'mimic', 'double-team', 'withdraw', 'haze', 'reflect', 'bide', 'waterfall', 'spike-cannon', 'constrict', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'spikes', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'knock-off', 'secret-power', 'dive', 'rock-tomb', 'tickle', 'muddy-water', 'iron-defense', 'mud-shot', 'rock-blast', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'wring-out', 'toxic-spikes', 'rock-polish', 'earth-power', 'captivate', 'stealth-rock', 'smack-down', 'round', 'scald', 'shell-smash', 'reflect-type', 'confide'], 'name': 'omanyte', 'stats': {'hp': 35, 'attack': 40, 'defense': 100, 'special-attack': 90, 'special-defense': 55, 'speed': 35}, 'types': ['rock', 'water'], 'weight': 75, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'tentacles', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'オムナイト', 'roomaji': 'Omnite', 'ko': '암나이트', 'zh-Hant': '菊石獸', 'fr': 'Amonita', 'de': 'Amonitas', 'es': 'Omanyte', 'it': 'Omanyte', 'en': 'Omanyte', 'ja': 'オムナイト', 'zh-Hans': '菊石兽'}, 'genera': {'ja-Hrkt': 'うずまきポケモン', 'ko': '소용돌이포켓몬', 'zh-Hant': '漩渦寶可夢', 'fr': 'Pokémon Spirale', 'de': 'Spirale', 'es': 'Pokémon Espiral', 'it': 'Pokémon Spirale', 'en': 'Spiral Pokémon', 'ja': 'うずまきポケモン', 'zh-Hans': '漩涡宝可梦'}}
	public class SpecieOmanyte : PokemonSpecie
	{
#nullable enable
		private static SpecieOmanyte? _instance = null;
#nullable restore
        public static SpecieOmanyte Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOmanyte();
                }
                return _instance;
            }
        }

		public SpecieOmanyte() : base(
			"Omanyte",
			35, // HPs
			40, 100, // Attack & Defense
			90, 55, // Special Attack & Defense
			35			
		) {}
	}


	//Omanyte Pokemon Class
	public class Omanyte : Pokemon
	{

		public Omanyte(string nickname, int level) : base(
			138,
			SpecieOmanyte.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Water.Instance			
		) {}

		public Omanyte() : base(
			138,
			SpecieOmanyte.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}