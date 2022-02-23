using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sudowoodo Specie to store common natural stats of every {'abilities': ['sturdy', 'rock-head', 'rattled'], 'base_experience': 144, 'height': 12, 'id': 185, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'low-kick', 'counter', 'seismic-toss', 'strength', 'rock-throw', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'sunny-day', 'psych-up', 'rock-smash', 'torment', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'secret-power', 'rock-tomb', 'sand-tomb', 'block', 'covet', 'calm-mind', 'hammer-arm', 'natural-gift', 'fling', 'copycat', 'sucker-punch', 'rock-polish', 'earth-power', 'stone-edge', 'captivate', 'stealth-rock', 'wood-hammer', 'head-smash', 'smack-down', 'foul-play', 'after-you', 'round', 'bulldoze', 'confide', 'power-up-punch', 'tearful-look'], 'name': 'sudowoodo', 'stats': {'hp': 70, 'attack': 100, 'defense': 115, 'special-attack': 30, 'special-defense': 65, 'speed': 30}, 'types': ['rock'], 'weight': 380, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 65, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ウソッキー', 'roomaji': 'Usokkie', 'ko': '꼬지모', 'zh-Hant': '樹才怪', 'fr': 'Simularbre', 'de': 'Mogelbaum', 'es': 'Sudowoodo', 'it': 'Sudowoodo', 'en': 'Sudowoodo', 'ja': 'ウソッキー', 'zh-Hans': '树才怪'}, 'genera': {'ja-Hrkt': 'まねポケモン', 'ko': '흉내포켓몬', 'zh-Hant': '模仿寶可夢', 'fr': 'Pokémon Imitation', 'de': 'Imitation', 'es': 'Pokémon Imitación', 'it': 'Pokémon Imitazione', 'en': 'Imitation Pokémon', 'ja': 'まねポケモン', 'zh-Hans': '模仿宝可梦'}}
	public class SpecieSudowoodo : PokemonSpecie
	{
#nullable enable
		private static SpecieSudowoodo? _instance = null;
#nullable restore
        public static SpecieSudowoodo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSudowoodo();
                }
                return _instance;
            }
        }

		public SpecieSudowoodo() : base(
			"Sudowoodo",
			70, // HPs
			100, 115, // Attack & Defense
			30, 65, // Special Attack & Defense
			30			
		) {}
	}


	//Sudowoodo Pokemon Class
	public class Sudowoodo : Pokemon
	{

		public Sudowoodo(string nickname, int level) : base(
			185,
			SpecieSudowoodo.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Sudowoodo() : base(
			185,
			SpecieSudowoodo.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}