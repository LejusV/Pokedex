using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nosepass Specie to store common natural stats of every {'abilities': ['sturdy', 'magnet-pull', 'sand-force'], 'base_experience': 75, 'height': 10, 'id': 299, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'rock-throw', 'earthquake', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'zap-cannon', 'lock-on', 'sandstorm', 'endure', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'magnitude', 'dynamic-punch', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'torment', 'facade', 'taunt', 'magic-coat', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'shock-wave', 'gravity', 'natural-gift', 'magnet-rise', 'rock-polish', 'power-gem', 'earth-power', 'discharge', 'stone-edge', 'captivate', 'stealth-rock', 'head-smash', 'wide-guard', 'smack-down', 'round', 'volt-switch', 'bulldoze', 'confide', 'dazzling-gleam'], 'name': 'nosepass', 'stats': {'hp': 30, 'attack': 45, 'defense': 135, 'special-attack': 45, 'special-defense': 90, 'speed': 30}, 'types': ['rock'], 'weight': 970, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ノズパス', 'roomaji': 'Nosepass', 'ko': '코코파스', 'zh-Hant': '朝北鼻', 'fr': 'Tarinor', 'de': 'Nasgnet', 'es': 'Nosepass', 'it': 'Nosepass', 'en': 'Nosepass', 'ja': 'ノズパス', 'zh-Hans': '朝北鼻'}, 'genera': {'ja-Hrkt': 'コンパスポケモン', 'ko': '콤파스포켓몬', 'zh-Hant': '羅盤寶可夢', 'fr': 'Pokémon Boussole', 'de': 'Kompass', 'es': 'Pokémon Brújula', 'it': 'Pokémon Bussola', 'en': 'Compass Pokémon', 'ja': 'コンパスポケモン', 'zh-Hans': '罗盘宝可梦'}}
	public class SpecieNosepass : PokemonSpecie
	{
#nullable enable
		private static SpecieNosepass? _instance = null;
#nullable restore
        public static SpecieNosepass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNosepass();
                }
                return _instance;
            }
        }

		public SpecieNosepass() : base(
			"Nosepass",
			30, // HPs
			45, 135, // Attack & Defense
			45, 90, // Special Attack & Defense
			30			
		) {}
	}


	//Nosepass Pokemon Class
	public class Nosepass : Pokemon
	{

		public Nosepass(string nickname, int level) : base(
			299,
			SpecieNosepass.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Nosepass() : base(
			299,
			SpecieNosepass.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}