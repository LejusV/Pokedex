using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aron Specie to store common natural stats of every {'abilities': ['sturdy', 'rock-head', 'heavy-metal'], 'base_experience': 66, 'height': 4, 'id': 304, 'moves': ['cut', 'stomp', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'harden', 'defense-curl', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'reversal', 'spite', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'smelling-salts', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'shock-wave', 'water-pulse', 'natural-gift', 'metal-burst', 'magnet-rise', 'rock-polish', 'dragon-rush', 'earth-power', 'shadow-claw', 'iron-head', 'captivate', 'stealth-rock', 'head-smash', 'hone-claws', 'autotomize', 'heavy-slam', 'round', 'bulldoze', 'confide'], 'name': 'aron', 'stats': {'hp': 50, 'attack': 70, 'defense': 100, 'special-attack': 40, 'special-defense': 40, 'speed': 30}, 'types': ['steel', 'rock'], 'weight': 600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 4, 'capture_rate': 180, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ココドラ', 'roomaji': 'Cokodora', 'ko': '가보리', 'zh-Hant': '可可多拉', 'fr': 'Galekid', 'de': 'Stollunior', 'es': 'Aron', 'it': 'Aron', 'en': 'Aron', 'ja': 'ココドラ', 'zh-Hans': '可可多拉'}, 'genera': {'ja-Hrkt': 'てつヨロイポケモン', 'ko': '철갑옷포켓몬', 'zh-Hant': '鐵鎧寶可夢', 'fr': 'Pokémon Armurfer', 'de': 'Eisenpanzer', 'es': 'Pokémon Cor. Férrea', 'it': 'Pokémon Corazza', 'en': 'Iron Armor Pokémon', 'ja': 'てつヨロイポケモン', 'zh-Hans': '铁铠宝可梦'}}
	public class SpecieAron : PokemonSpecie
	{
#nullable enable
		private static SpecieAron? _instance = null;
#nullable restore
        public static SpecieAron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAron();
                }
                return _instance;
            }
        }

		public SpecieAron() : base(
			"Aron",
			50, // HPs
			70, 100, // Attack & Defense
			40, 40, // Special Attack & Defense
			30			
		) {}
	}


	//Aron Pokemon Class
	public class Aron : Pokemon
	{

		public Aron(string nickname, int level) : base(
			304,
			SpecieAron.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Rock.Instance			
		) {}

		public Aron() : base(
			304,
			SpecieAron.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
	}
}