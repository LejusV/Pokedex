using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hawlucha Specie to store common natural stats of every {'abilities': ['limber', 'unburden', 'mold-breaker'], 'base_experience': 175, 'height': 8, 'id': 701, 'moves': ['karate-chop', 'fire-punch', 'thunder-punch', 'swords-dance', 'cut', 'wing-attack', 'fly', 'tackle', 'low-kick', 'strength', 'dig', 'toxic', 'agility', 'double-team', 'high-jump-kick', 'sky-attack', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'detect', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'feather-dance', 'mud-sport', 'rock-tomb', 'aerial-ace', 'bulk-up', 'bounce', 'roost', 'feint', 'tailwind', 'u-turn', 'payback', 'fling', 'me-first', 'last-resort', 'poison-jab', 'x-scissor', 'drain-punch', 'focus-blast', 'giga-impact', 'zen-headbutt', 'iron-head', 'stone-edge', 'grass-knot', 'hone-claws', 'low-sweep', 'entrainment', 'round', 'quick-guard', 'ally-switch', 'sky-drop', 'acrobatics', 'retaliate', 'work-up', 'dual-chop', 'flying-press', 'confide', 'power-up-punch'], 'name': 'hawlucha', 'stats': {'hp': 78, 'attack': 92, 'defense': 75, 'special-attack': 74, 'special-defense': 63, 'speed': 118}, 'types': ['fighting', 'flying'], 'weight': 215, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 100, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ルチャブル', 'ko': '루차불', 'zh-Hant': '摔角鷹人', 'fr': 'Brutalibré', 'de': 'Resladero', 'es': 'Hawlucha', 'it': 'Hawlucha', 'en': 'Hawlucha', 'ja': 'ルチャブル', 'zh-Hans': '摔角鹰人'}, 'genera': {'ja-Hrkt': 'レスリングポケモン', 'ko': '레슬링포켓몬', 'zh-Hant': '摔角寶可夢', 'fr': 'Pokémon Catcheur', 'de': 'Wrestling', 'es': 'Pokémon Lucha Libre', 'it': 'Pokémon Lottalibera', 'en': 'Wrestling Pokémon', 'ja': 'レスリングポケモン', 'zh-Hans': '摔角宝可梦'}}
	public class SpecieHawlucha : PokemonSpecie
	{
#nullable enable
		private static SpecieHawlucha? _instance = null;
#nullable restore
        public static SpecieHawlucha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHawlucha();
                }
                return _instance;
            }
        }

		public SpecieHawlucha() : base(
			"Hawlucha",
			78, // HPs
			92, 75, // Attack & Defense
			74, 63, // Special Attack & Defense
			118			
		) {}
	}


	//Hawlucha Pokemon Class
	public class Hawlucha : Pokemon
	{

		public Hawlucha(string nickname, int level) : base(
			701,
			SpecieHawlucha.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance, Flying.Instance			
		) {}

		public Hawlucha() : base(
			701,
			SpecieHawlucha.Instance, // Pokemon Specie
			Fighting.Instance, Flying.Instance			
		) {}
	}
}