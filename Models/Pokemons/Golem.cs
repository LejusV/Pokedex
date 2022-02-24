using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golem Specie to store common natural stats of every {'abilities': ['rock-head', 'sturdy', 'sand-veil'], 'base_experience': 223, 'height': 14, 'id': 76, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'flamethrower', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'rock-throw', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'harden', 'defense-curl', 'bide', 'metronome', 'self-destruct', 'fire-blast', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'dynamic-punch', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'superpower', 'brick-break', 'secret-power', 'mud-sport', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'gyro-ball', 'natural-gift', 'fling', 'sucker-punch', 'rock-polish', 'focus-blast', 'earth-power', 'giga-impact', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'heavy-slam', 'round', 'incinerate', 'bulldoze', 'steamroller', 'confide', 'power-up-punch'], 'name': 'golem', 'stats': {'hp': 80, 'attack': 120, 'defense': 130, 'special-attack': 55, 'special-defense': 65, 'speed': 45}, 'types': ['rock', 'ground'], 'weight': 3000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ゴローニャ', 'roomaji': 'Golonya', 'ko': '딱구리', 'zh-Hant': '隆隆岩', 'fr': 'Grolem', 'de': 'Geowaz', 'es': 'Golem', 'it': 'Golem', 'en': 'Golem', 'ja': 'ゴローニャ', 'zh-Hans': '隆隆岩'}, 'genera': {'ja-Hrkt': 'メガトンポケモン', 'ko': '메가톤포켓몬', 'zh-Hant': '重量級寶可夢', 'fr': 'Pokémon Titanesque', 'de': 'Urgestein', 'es': 'Pokémon Megatón', 'it': 'Pokémon Megatone', 'en': 'Megaton Pokémon', 'ja': 'メガトンポケモン', 'zh-Hans': '重量级宝可梦'}}
	public class SpecieGolem : PokemonSpecie
	{
#nullable enable
		private static SpecieGolem? _instance = null;
#nullable restore
        public static SpecieGolem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolem();
                }
                return _instance;
            }
        }

		public SpecieGolem() : base(
			"Golem",
			80, // HPs
			120, 130, // Attack & Defense
			55, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Golem Pokemon Class
	public class Golem : Pokemon
	{

		public Golem(string nickname, int level)
		: base(
				76,
				SpecieGolem.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Golem() : base(
			76,
			SpecieGolem.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}