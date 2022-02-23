using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Donphan Specie to store common natural stats of every {'abilities': ['sturdy', 'sand-veil'], 'base_experience': 175, 'height': 11, 'id': 232, 'moves': ['slam', 'headbutt', 'horn-attack', 'fury-attack', 'body-slam', 'double-edge', 'growl', 'roar', 'hyper-beam', 'counter', 'strength', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'rapid-spin', 'iron-tail', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'knock-off', 'endeavor', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'iron-defense', 'block', 'bounce', 'gyro-ball', 'natural-gift', 'assurance', 'last-resort', 'rock-polish', 'poison-jab', 'seed-bomb', 'earth-power', 'giga-impact', 'thunder-fang', 'fire-fang', 'gunk-shot', 'stone-edge', 'captivate', 'stealth-rock', 'round', 'echoed-voice', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'donphan', 'stats': {'hp': 90, 'attack': 120, 'defense': 120, 'special-attack': 60, 'special-defense': 60, 'speed': 50}, 'types': ['ground'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ドンファン', 'roomaji': 'Donfan', 'ko': '코리갑', 'zh-Hant': '頓甲', 'fr': 'Donphan', 'de': 'Donphan', 'es': 'Donphan', 'it': 'Donphan', 'en': 'Donphan', 'ja': 'ドンファン', 'zh-Hans': '顿甲'}, 'genera': {'ja-Hrkt': 'よろいポケモン', 'ko': '갑옷포켓몬', 'zh-Hant': '鎧甲寶可夢', 'fr': 'Pokémon Armure', 'de': 'Panzer', 'es': 'Pokémon Coraza', 'it': 'Pokémon Armatura', 'en': 'Armor Pokémon', 'ja': 'よろいポケモン', 'zh-Hans': '铠甲宝可梦'}}
	public class SpecieDonphan : PokemonSpecie
	{
#nullable enable
		private static SpecieDonphan? _instance = null;
#nullable restore
        public static SpecieDonphan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDonphan();
                }
                return _instance;
            }
        }

		public SpecieDonphan() : base(
			"Donphan",
			90, // HPs
			120, 120, // Attack & Defense
			60, 60, // Special Attack & Defense
			50			
		) {}
	}


	//Donphan Pokemon Class
	public class Donphan : Pokemon
	{

		public Donphan(string nickname, int level) : base(
			232,
			SpecieDonphan.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Donphan() : base(
			232,
			SpecieDonphan.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}