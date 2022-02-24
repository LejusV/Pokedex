using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carracosta Specie to store common natural stats of every {'abilities': ['solid-rock', 'sturdy', 'swift-swim'], 'base_experience': 173, 'height': 12, 'id': 565, 'moves': ['bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'bide', 'waterfall', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'sandstorm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'knock-off', 'secret-power', 'dive', 'rock-tomb', 'iron-defense', 'block', 'water-pulse', 'brine', 'rock-polish', 'aqua-tail', 'focus-blast', 'earth-power', 'giga-impact', 'zen-headbutt', 'iron-head', 'stone-edge', 'stealth-rock', 'aqua-jet', 'wide-guard', 'smack-down', 'round', 'scald', 'shell-smash', 'bulldoze', 'confide'], 'name': 'carracosta', 'stats': {'hp': 74, 'attack': 108, 'defense': 133, 'special-attack': 83, 'special-defense': 65, 'speed': 32}, 'types': ['water', 'rock'], 'weight': 810, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'アバゴーラ', 'ko': '늑골라', 'zh-Hant': '肋骨海龜', 'fr': 'Mégapagos', 'de': 'Karippas', 'es': 'Carracosta', 'it': 'Carracosta', 'en': 'Carracosta', 'ja': 'アバゴーラ', 'zh-Hans': '肋骨海龟'}, 'genera': {'ja-Hrkt': 'こだいがめポケモン', 'ko': '옛날거북포켓몬', 'zh-Hant': '古代龜寶可夢', 'fr': 'Pokémon Tortantique', 'de': 'Urzeitkröte', 'es': 'Pokémon Pretortuga', 'it': 'Pokémon Ancestruga', 'en': 'Prototurtle Pokémon', 'ja': 'こだいがめポケモン', 'zh-Hans': '古代龟宝可梦'}}
	public class SpecieCarracosta : PokemonSpecie
	{
#nullable enable
		private static SpecieCarracosta? _instance = null;
#nullable restore
        public static SpecieCarracosta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarracosta();
                }
                return _instance;
            }
        }

		public SpecieCarracosta() : base(
			"Carracosta",
			74, // HPs
			108, 133, // Attack & Defense
			83, 65, // Special Attack & Defense
			32			
		) {}
	}


	//Carracosta Pokemon Class
	public class Carracosta : Pokemon
	{

		public Carracosta(string nickname, int level)
		: base(
				565,
				SpecieCarracosta.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carracosta() : base(
			565,
			SpecieCarracosta.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
	}
}